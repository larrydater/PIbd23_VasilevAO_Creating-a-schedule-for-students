using Creating_a_schedule_for_students.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Entities
{
    public class Lesson
    {
        public int Id { get; private set; }
        public int ClassroomId { get; private set; }
        public int StudentGroupId { get; private set; }
        public int TeacherId { get; private set; }
        public int DisciplineId { get; private set; }
        public LessonType LessonType { get; private set; }
        public WeekDay WeekDay { get; private set; }
        public int PairNumber { get; private set; }

        public static Lesson CreateOperation(int id, int classroomId, int studentGroupId, int teacherId, int disciplineId, LessonType lessonType, WeekDay weekDay, int pairNumber)
        {
            return new Lesson
            {
                Id = id,
                ClassroomId = classroomId,
                StudentGroupId = studentGroupId,
                TeacherId = teacherId,
                DisciplineId = disciplineId,
                LessonType = lessonType,
                WeekDay = weekDay,
                PairNumber = pairNumber
            };
        }
    }
}
