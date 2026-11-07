using Creating_a_schedule_for_students.Forms;
using Creating_a_schedule_for_students.Repositories;
using Creating_a_schedule_for_students.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace Creating_a_schedule_for_students
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormSchedule>());
        }
        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IClassroomRepository, ClassroomRepository>(new TransientLifetimeManager());
            container.RegisterType<IStudentGroupRepository, StudentGroupRepository>(new TransientLifetimeManager());
            container.RegisterType<ITeacherRepository, TeacherRepository>(new TransientLifetimeManager());
            container.RegisterType<IDisciplineRepository, DisciplineRepository>(new TransientLifetimeManager());
            container.RegisterType<ILessonRepository, LessonRepository>(new TransientLifetimeManager());
            container.RegisterType<ICurriculumPlanRepository, CurriculumPlanRepository>(new TransientLifetimeManager());

            return container;
        }

    }
}