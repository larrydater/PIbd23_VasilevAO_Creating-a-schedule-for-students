using Creating_a_schedule_for_students.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Entities
{
    public class Discipline
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;

        public static Discipline CreateEntity(int id, string name)
        {
            return new Discipline
            {
                Id = id,
                Name = name ?? string.Empty,
            };
        }
    }
}
