using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Entities.Enums;

namespace Creating_a_schedule_for_students.Repositories.Implementations;

internal class DisciplineRepository : IDisciplineRepository
{
    public void CreateDiscipline(Discipline discipline)
    {
    }

    public void DeleteDiscipline(int id)
    {
    }

    public Discipline ReadDisciplineById(int id)
    {
        return Discipline.CreateEntity(0, string.Empty);
    }

    public IEnumerable<Discipline> ReadDisciplines()
    {
        return [];
    }

    public void UpdateDiscipline(Discipline discipline)
    {
    }
}
