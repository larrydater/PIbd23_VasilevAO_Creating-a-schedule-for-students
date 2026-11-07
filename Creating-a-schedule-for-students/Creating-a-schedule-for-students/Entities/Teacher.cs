using Creating_a_schedule_for_students.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Entities
{
    public class Teacher
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public TeacherPost TeacherPost { get; private set; }

        public static Teacher CreateEntity(int id, string Name, TeacherPost teacherPost)
        {
            return new Teacher
            {
                Id = id,
                Name = Name ?? string.Empty,
                TeacherPost = teacherPost
            };
        }
    }
}
