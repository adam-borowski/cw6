using Cw6.DTOs.Requests;
using Cw6.Models;

namespace Cw6.Services
{
    public interface IStudentDbService
    {
        Enrollment EnrollStudent(EnrollStudentRequest request);
        Enrollment PromoteStudents(PromoteStudentRequest request);

        Student GetStudent(string indexNumber);
    }
}