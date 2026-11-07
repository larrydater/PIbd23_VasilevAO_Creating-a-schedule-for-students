using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Entities.Enums
{

    [Flags]
    public enum TeacherPost
    {
        None = 0,
        Laboratory_technician = 1,
        Lecturer = 2,
    }
}
