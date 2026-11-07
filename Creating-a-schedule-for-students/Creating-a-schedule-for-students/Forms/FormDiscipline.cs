using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Repositories;

namespace Creating_a_schedule_for_students.Forms;

public partial class FormDiscipline : Form
{
    private readonly IDisciplineRepository _disciplineRepository;
    private int? _disciplineId;

    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var discipline = _disciplineRepository.ReadDisciplineById(value);
                if (discipline == null)
                {
                    throw new InvalidDataException(nameof(discipline));
                }

                textBoxName.Text = discipline.Name;
                _disciplineId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormDiscipline(IDisciplineRepository disciplineRepository)
    {
        InitializeComponent();
        _disciplineRepository = disciplineRepository ??
            throw new ArgumentNullException(nameof(disciplineRepository));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_disciplineId.HasValue)
            {
                _disciplineRepository.UpdateDiscipline(CreateDiscipline(_disciplineId.Value));
            }
            else
            {
                _disciplineRepository.CreateDiscipline(CreateDiscipline(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Discipline CreateDiscipline(int id) => Discipline.CreateEntity(id, textBoxName.Text);
}
