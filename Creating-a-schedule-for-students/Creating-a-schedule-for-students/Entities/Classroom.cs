using Creating_a_schedule_for_students.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Entities
{
    public class Classroom
    {
        public int Id { get; private set; }
        public string Number { get; private set; } = string.Empty;
        public int Capacity { get; private set; }
        public ClassroomType ClassroomType { get; private set; }

        public static Classroom CreateEntity(int id, string number, int capacity, ClassroomType classroomType)
        {
            return new Classroom
            {
                Id = id,
                Number = number ?? string.Empty,
                Capacity = capacity,
                ClassroomType = classroomType
            };
        }
    }
}
