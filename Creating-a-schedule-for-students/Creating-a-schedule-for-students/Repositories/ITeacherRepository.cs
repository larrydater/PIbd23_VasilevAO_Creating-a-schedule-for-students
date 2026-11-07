using Creating_a_schedule_for_students.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> ReadTeachers();
        Teacher ReadTeacherById(int id);
        void CreateTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int id);
    }
}
