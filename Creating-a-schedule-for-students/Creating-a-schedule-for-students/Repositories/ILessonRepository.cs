using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Repositories
{
    public interface ILessonRepository
    {
        IEnumerable<Lesson> ReadLessons(int? studentGroupId = null, int? teacherId = null, int? classroomId = null, int? disciplineId = null, WeekDay? weekDay = null);
        void CreateLesson(Lesson lesson);
    }
}
