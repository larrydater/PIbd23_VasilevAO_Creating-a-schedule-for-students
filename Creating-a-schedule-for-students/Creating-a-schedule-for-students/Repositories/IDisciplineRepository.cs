using Creating_a_schedule_for_students.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Repositories
{
    public interface IDisciplineRepository
    {
        IEnumerable<Discipline> ReadDisciplines();
        Discipline ReadDisciplineById(int id);
        void CreateDiscipline(Discipline discipline);
        void UpdateDiscipline(Discipline discipline);
        void DeleteDiscipline(int id);
    }
}
