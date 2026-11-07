using Creating_a_schedule_for_students.Entities;

namespace Creating_a_schedule_for_students.Repositories.Implementations;

internal class CurriculumPlanRepository : ICurriculumPlanRepository
{
    public void CreateCurriculumPlan(CurriculumPlan curriculumPlan)
    {
    }

    public void DeleteCurriculumPlan(int id)
    {
    }

    public IEnumerable<CurriculumPlan> ReadCurriculumPlans(int? studentGroupId = null, int? semester = null)
    {
        return [];
    }
}
