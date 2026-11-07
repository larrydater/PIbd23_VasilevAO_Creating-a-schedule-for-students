using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Entities
{
    public class CurriculumPlanDiscipline
    {
        public int Id { get; private set; }
        public int DisciplineId { get; private set; }
        public int LecturesCount { get; private set; }
        public int LabsCount { get; private set; }

        public static CurriculumPlanDiscipline CreateElement(int id, int disciplineId, int lecturesCount, int labsCount)
        {
            return new CurriculumPlanDiscipline
            {
                Id = id,
                DisciplineId = disciplineId,
                LecturesCount = lecturesCount,
                LabsCount = labsCount
            };
        }
    }
}
