using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Entities.Enums;

namespace Creating_a_schedule_for_students.Repositories.Implementations;

internal class TeacherRepository : ITeacherRepository
{
    public void CreateTeacher(Teacher teacher)
    {
    }

    public void DeleteTeacher(int id)
    {
    }

    public Teacher ReadTeacherById(int id)
    {
        return Teacher.CreateEntity(0, string.Empty, TeacherPost.None);
    }

    public IEnumerable<Teacher> ReadTeachers()
    {
        return [];
    }

    public void UpdateTeacher(Teacher teacher)
    {
    }
}
