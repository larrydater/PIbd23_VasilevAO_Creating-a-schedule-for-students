using Creating_a_schedule_for_students.Entities;
using Creating_a_schedule_for_students.Entities.Enums;

namespace Creating_a_schedule_for_students.Repositories.Implementations;

internal class LessonRepository : ILessonRepository
{
    public void CreateLesson(Lesson lesson)
    {
    }

    public IEnumerable<Lesson> ReadLessons(int? studentGroupId = null, int? teacherId = null,
        int? classroomId = null, int? disciplineId = null, WeekDay? weekDay = null)
    {
        return [];
    }
}
