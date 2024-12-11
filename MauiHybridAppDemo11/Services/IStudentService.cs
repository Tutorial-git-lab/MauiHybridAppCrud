using MauiHybridAppDemo11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHybridAppDemo11.Services
{
    public interface IStudentService
    {
        Task<List<StudentModel>> GetAllStudents();
        Task<StudentModel> GetStudentById(int StudentID);

        Task<int> AddStudent(StudentModel studentModel);

        Task<int> UpdateStudent(StudentModel studentModel);

        Task<int> DeleteStudent(StudentModel studentModel);

    }
}
