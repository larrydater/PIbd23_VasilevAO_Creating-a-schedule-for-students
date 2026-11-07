using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Entities.Enums;
using Creating_a_schedule_for_students.Repositories;

namespace Creating_a_schedule_for_students.Forms;

public partial class FormStudentGroup : Form
{
    private readonly IStudentGroupRepository _studentGroupRepository;
    private int? _studentGroupId;

    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var studentGroup = _studentGroupRepository.ReadStudentGroupById(value);
                if (studentGroup == null)
                {
                    throw new InvalidDataException(nameof(studentGroup));
                }

                textBoxName.Text = studentGroup.Name;
                numericUpDownCourse.Value = studentGroup.Course;
                numericUpDownStudentsCount.Value = studentGroup.StudentsCount;
                _studentGroupId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormStudentGroup(IStudentGroupRepository studentGroupRepository)
    {
        InitializeComponent();
        _studentGroupRepository = studentGroupRepository ??
            throw new ArgumentNullException(nameof(studentGroupRepository));

    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_studentGroupId.HasValue)
            {
                _studentGroupRepository.UpdateStudentGroup(CreateStudentGroup(_studentGroupId.Value));
            }
            else
            {
                _studentGroupRepository.CreateStudentGroup(CreateStudentGroup(0));
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

    private StudentGroup CreateStudentGroup(int id) => StudentGroup.CreateEntity(id,
        textBoxName.Text,
        Convert.ToInt32(numericUpDownCourse.Value),
        Convert.ToInt32(numericUpDownStudentsCount.Value));
}
