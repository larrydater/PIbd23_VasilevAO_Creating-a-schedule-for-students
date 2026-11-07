using Creating_a_schedule_for_students.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Repositories
{
    public interface ICurriculumPlanRepository
    {
        IEnumerable<CurriculumPlan> ReadCurriculumPlans(int? studentGroupId = null, int? semester = null);
        void CreateCurriculumPlan(CurriculumPlan curriculumPlan);
        void DeleteCurriculumPlan(int id);
    }
}
