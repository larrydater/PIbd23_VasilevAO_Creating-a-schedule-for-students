using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Entities
{
    public class StudentGroup
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public int Course { get; private set; }
        public int StudentsCount { get; private set; }

        public static StudentGroup CreateEntity(int id, string name, int course, int studentsCount)
        {
            return new StudentGroup
            {
                Id = id,
                Name = name ?? string.Empty,
                Course = course,
                StudentsCount = studentsCount
            };
        }
    }
}
