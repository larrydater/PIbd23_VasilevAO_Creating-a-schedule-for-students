using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Repositories.Implementations
{
    internal class ClassroomRepository : IClassroomRepository
    {
        public void CreateClassroom(Classroom classroom)
        {
        }
        public void DeleteClassroom(int id)
        {
        }
        public Classroom ReadClassroomById(int id)
        {
            return Classroom.CreateEntity(0, string.Empty, 0, ClassroomType.None);
        }
        public IEnumerable<Classroom> ReadClassrooms()
        {
            return [];
        }
        public void UpdateClassroom(Classroom classroom)
        {
        }
    }
}
