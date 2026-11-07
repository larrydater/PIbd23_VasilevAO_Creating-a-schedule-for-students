using Creating_a_schedule_for_students.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Repositories
{
    public interface IClassroomRepository
    {
        IEnumerable<Classroom> ReadClassrooms();
        Classroom ReadClassroomById(int id);
        void CreateClassroom(Classroom classroom);
        void UpdateClassroom(Classroom classroom);
        void DeleteClassroom(int id);
    }
}