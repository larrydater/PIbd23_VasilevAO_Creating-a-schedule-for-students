using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Entities
{
    public class CurriculumPlan
    {
        public int Id { get; private set; }
        public int StudentGroupId { get; private set; }
        public int Semester { get; private set; }
        public IEnumerable<CurriculumPlanDiscipline> CurriculumPlanDisciplines { get; private set; } = [];

        public static CurriculumPlan CreateOperation(int id, int studentGroupId, int semester, IEnumerable<CurriculumPlanDiscipline> curriculumPlanDisciplines)
        {
            return new CurriculumPlan
            {
                Id = id,
                StudentGroupId = studentGroupId,
                Semester = semester,
                CurriculumPlanDisciplines = curriculumPlanDisciplines ?? []
            };
        }
    }
}
