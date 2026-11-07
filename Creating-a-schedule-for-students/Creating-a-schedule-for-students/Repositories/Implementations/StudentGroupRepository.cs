using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Entities.Enums;

namespace Creating_a_schedule_for_students.Repositories.Implementations;

internal class StudentGroupRepository : IStudentGroupRepository
{
    public void CreateStudentGroup(StudentGroup studentGroup)
    {
    }

    public void DeleteStudentGroup(int id)
    {
    }

    public StudentGroup ReadStudentGroupById(int id)
    {
        return StudentGroup.CreateEntity(0, string.Empty, 0, 0);
    }

    public IEnumerable<StudentGroup> ReadStudentGroups()
    {
        return [];
    }

    public void UpdateStudentGroup(StudentGroup studentGroup)
    {
    }
}
