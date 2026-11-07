using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Repositories;

namespace Creating_a_schedule_for_students.Forms;

public partial class FormCurriculumPlan : Form
{
    private readonly ICurriculumPlanRepository _curriculumPlanRepository;

    public FormCurriculumPlan(ICurriculumPlanRepository curriculumPlanRepository,
        IStudentGroupRepository studentGroupRepository, IDisciplineRepository disciplineRepository)
    {
        InitializeComponent();
        _curriculumPlanRepository = curriculumPlanRepository ??
            throw new ArgumentNullException(nameof(curriculumPlanRepository));

        comboBoxStudentGroup.DataSource = studentGroupRepository.ReadStudentGroups();
        comboBoxStudentGroup.DisplayMember = "Name";
        comboBoxStudentGroup.ValueMember = "Id";

        ColumnDiscipline.DataSource = disciplineRepository.ReadDisciplines();
        ColumnDiscipline.DisplayMember = "Name";
        ColumnDiscipline.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxStudentGroup.SelectedIndex < 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            var disciplines = CreateListCurriculumPlanDisciplinesFromDataGrid();
            if (disciplines.Count == 0)
            {
                throw new Exception("Не добавлено ни одной дисциплины");
            }

            _curriculumPlanRepository.CreateCurriculumPlan(CurriculumPlan.CreateOperation(
                0,
                (int)comboBoxStudentGroup.SelectedValue!,
                Convert.ToInt32(numericUpDownSemester.Value),
                disciplines));
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private List<CurriculumPlanDiscipline> CreateListCurriculumPlanDisciplinesFromDataGrid()
    {
        var list = new List<CurriculumPlanDiscipline>();
        foreach (DataGridViewRow row in dataGridViewDisciplines.Rows)
        {
            if (row.Cells["ColumnDiscipline"].Value == null ||
                row.Cells["ColumnLecturesCount"].Value == null ||
                row.Cells["ColumnLabsCount"].Value == null)
            {
                continue;
            }

            list.Add(CurriculumPlanDiscipline.CreateElement(0,
                Convert.ToInt32(row.Cells["ColumnDiscipline"].Value),
                Convert.ToInt32(row.Cells["ColumnLecturesCount"].Value),
                Convert.ToInt32(row.Cells["ColumnLabsCount"].Value)));
        }

        return list;
    }
}
