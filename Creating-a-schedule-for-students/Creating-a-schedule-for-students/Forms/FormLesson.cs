using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Entities.Enums;
using Creating_a_schedule_for_students.Repositories;

namespace Creating_a_schedule_for_students.Forms;

public partial class FormLesson : Form
{
    private readonly ILessonRepository _lessonRepository;

    public FormLesson(ILessonRepository lessonRepository,
        IClassroomRepository classroomRepository, IStudentGroupRepository studentGroupRepository,
        ITeacherRepository teacherRepository, IDisciplineRepository disciplineRepository)
    {
        InitializeComponent();
        _lessonRepository = lessonRepository ??
            throw new ArgumentNullException(nameof(lessonRepository));

        comboBoxClassroom.DataSource = classroomRepository.ReadClassrooms();
        comboBoxClassroom.DisplayMember = "Number";
        comboBoxClassroom.ValueMember = "Id";

        comboBoxStudentGroup.DataSource = studentGroupRepository.ReadStudentGroups();
        comboBoxStudentGroup.DisplayMember = "Name";
        comboBoxStudentGroup.ValueMember = "Id";

        comboBoxTeacher.DataSource = teacherRepository.ReadTeachers();
        comboBoxTeacher.DisplayMember = "LastName";
        comboBoxTeacher.ValueMember = "Id";

        comboBoxDiscipline.DataSource = disciplineRepository.ReadDisciplines();
        comboBoxDiscipline.DisplayMember = "Name";
        comboBoxDiscipline.ValueMember = "Id";

        comboBoxLessonType.DataSource = new[] { LessonType.Lecture, LessonType.Laboratory };
        comboBoxWeekDay.DataSource = Enum.GetValues(typeof(WeekDay));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxClassroom.SelectedIndex < 0 ||
                comboBoxStudentGroup.SelectedIndex < 0 ||
                comboBoxTeacher.SelectedIndex < 0 ||
                comboBoxDiscipline.SelectedIndex < 0 ||
                comboBoxLessonType.SelectedIndex < 0 ||
                comboBoxWeekDay.SelectedIndex < 1)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _lessonRepository.CreateLesson(Lesson.CreateOperation(
                0,
                (int)comboBoxClassroom.SelectedValue!,
                (int)comboBoxStudentGroup.SelectedValue!,
                (int)comboBoxTeacher.SelectedValue!,
                (int)comboBoxDiscipline.SelectedValue!,
                (LessonType)comboBoxLessonType.SelectedItem!,
                (WeekDay)comboBoxWeekDay.SelectedItem!,
                Convert.ToInt32(numericUpDownPairNumber.Value)));
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}
