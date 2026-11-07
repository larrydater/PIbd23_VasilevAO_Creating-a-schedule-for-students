using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Entities.Enums;
using Creating_a_schedule_for_students.Repositories;

namespace Creating_a_schedule_for_students.Forms;

public partial class FormTeacher : Form
{
    private readonly ITeacherRepository _teacherRepository;
    private int? _teacherId;

    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var teacher = _teacherRepository.ReadTeacherById(value);
                if (teacher == null)
                {
                    throw new InvalidDataException(nameof(teacher));
                }

                textBoxName.Text = teacher.Name;
                comboBoxTeacherPost.SelectedItem = teacher.TeacherPost;
                _teacherId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormTeacher(ITeacherRepository teacherRepository)
    {
        InitializeComponent();
        _teacherRepository = teacherRepository ??
            throw new ArgumentNullException(nameof(teacherRepository));
        comboBoxTeacherPost.DataSource = Enum.GetValues(typeof(TeacherPost));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||comboBoxTeacherPost.SelectedIndex < 1)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_teacherId.HasValue)
            {
                _teacherRepository.UpdateTeacher(CreateTeacher(_teacherId.Value));
            }
            else
            {
                _teacherRepository.CreateTeacher(CreateTeacher(0));
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

    private Teacher CreateTeacher(int id) => Teacher.CreateEntity(id,textBoxName.Text,(TeacherPost)comboBoxTeacherPost.SelectedItem!);
}
