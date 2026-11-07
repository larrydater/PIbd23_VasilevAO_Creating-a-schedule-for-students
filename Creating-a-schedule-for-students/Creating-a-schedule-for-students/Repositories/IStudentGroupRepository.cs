using Creating_a_schedule_for_students.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_a_schedule_for_students.Repositories
{
    public interface IStudentGroupRepository
    {
        IEnumerable<StudentGroup> ReadStudentGroups();
        StudentGroup ReadStudentGroupById(int id);
        void CreateStudentGroup(StudentGroup studentGroup);
        void UpdateStudentGroup(StudentGroup studentGroup);
        void DeleteStudentGroup(int id);
    }
}
