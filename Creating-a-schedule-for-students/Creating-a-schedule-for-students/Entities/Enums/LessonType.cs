using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Entities.Enums
{

    [Flags]
    public enum LessonType
    {
        None = 0,
        Lecture = 1,
        Laboratory = 2
    }
}
