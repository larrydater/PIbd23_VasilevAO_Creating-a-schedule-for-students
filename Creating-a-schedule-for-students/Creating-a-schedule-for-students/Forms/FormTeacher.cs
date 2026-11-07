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
                foreach (TeacherPost elem in Enum.GetValues(typeof(TeacherPost)))
                {
                    if (elem != TeacherPost.None && (elem & teacher.TeacherPost) != 0)
                    {
                        checkedListBoxTeacherPost.SetItemChecked(
                            checkedListBoxTeacherPost.Items.IndexOf(elem), true);
                    }
                }
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
        foreach (TeacherPost elem in Enum.GetValues(typeof(TeacherPost)))
        {
            if (elem != TeacherPost.None)
            {
                checkedListBoxTeacherPost.Items.Add(elem);
            }
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || checkedListBoxTeacherPost.CheckedItems.Count == 0)
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

    private Teacher CreateTeacher(int id)
    {
        var teacherPost = TeacherPost.None;
        foreach (var elem in checkedListBoxTeacherPost.CheckedItems)
        {
            teacherPost |= (TeacherPost)elem;
        }

        return Teacher.CreateEntity(id,
            textBoxName.Text,
            teacherPost);
    }
}
