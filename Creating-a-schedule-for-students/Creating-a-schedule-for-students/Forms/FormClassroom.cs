using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Entities.Enums;
using Creating_a_schedule_for_students.Repositories;

namespace Creating_a_schedule_for_students.Forms;

public partial class FormClassroom : Form
{
    private readonly IClassroomRepository _classroomRepository;
    private int? _classroomId;

    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var classroom = _classroomRepository.ReadClassroomById(value);
                if (classroom == null)
                {
                    throw new InvalidDataException(nameof(classroom));
                }

                textBoxNumber.Text = classroom.Number;
                numericUpDownCapacity.Value = classroom.Capacity;
                comboBoxClassroomType.SelectedItem = classroom.ClassroomType;
                _classroomId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormClassroom(IClassroomRepository classroomRepository)
    {
        InitializeComponent();
        _classroomRepository = classroomRepository ??
            throw new ArgumentNullException(nameof(classroomRepository));
        comboBoxClassroomType.DataSource = Enum.GetValues(typeof(ClassroomType));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxNumber.Text) ||
                comboBoxClassroomType.SelectedIndex < 1)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_classroomId.HasValue)
            {
                _classroomRepository.UpdateClassroom(CreateClassroom(_classroomId.Value));
            }
            else
            {
                _classroomRepository.CreateClassroom(CreateClassroom(0));
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

    private Classroom CreateClassroom(int id) => Classroom.CreateEntity(id,
        textBoxNumber.Text,
        Convert.ToInt32(numericUpDownCapacity.Value),
        (ClassroomType)comboBoxClassroomType.SelectedItem!);
}
