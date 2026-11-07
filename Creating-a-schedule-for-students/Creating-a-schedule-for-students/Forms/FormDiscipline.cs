using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Entities.Enums;
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

                foreach (LessonType elem in Enum.GetValues(typeof(LessonType)))
                {
                    if (elem != LessonType.None && (elem & discipline.LessonTypes) != 0)
                    {
                        checkedListBoxLessonTypes.SetItemChecked(checkedListBoxLessonTypes.Items.IndexOf(elem), true);
                    }
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
        foreach (LessonType elem in Enum.GetValues(typeof(LessonType)))
        {
            if (elem != LessonType.None)
            {
                checkedListBoxLessonTypes.Items.Add(elem);
            }
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                checkedListBoxLessonTypes.CheckedItems.Count == 0)
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

    private Discipline CreateDiscipline(int id)
    {
        var lessonTypes = LessonType.None;
        foreach (var elem in checkedListBoxLessonTypes.CheckedItems)
        {
            lessonTypes |= (LessonType)elem;
        }

        return Discipline.CreateEntity(id, textBoxName.Text, lessonTypes);
    }
}
