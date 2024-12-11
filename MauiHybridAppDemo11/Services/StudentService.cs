using MauiHybridAppDemo11.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHybridAppDemo11.Services
{
    public class StudentService : IStudentService
    {
        private SQLiteAsyncConnection _dbConnection;

        public StudentService()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Student.db3");
            _dbConnection = new SQLiteAsyncConnection(dbPath);
            await _dbConnection.CreateTableAsync<StudentModel>();
        }
        public async Task<int> AddStudent(StudentModel studentModel)
        {
           return await _dbConnection.InsertAsync(studentModel); 

        }

        public async Task<int> DeleteStudent(StudentModel studentModel)
        {
            return await _dbConnection.DeleteAsync(studentModel);
        }

        public async Task<List<StudentModel>> GetAllStudents()
        {
            return await _dbConnection.Table<StudentModel>().ToListAsync();
        }

        public async Task<int> UpdateStudent(StudentModel studentModel)
        {
            return await _dbConnection.UpdateAsync(studentModel);
        }

        public async Task<StudentModel> GetStudentById(int StudentID)
        {
            var student = await _dbConnection.QueryAsync<StudentModel>($"Select * from {nameof(StudentModel)}  where StudentID={StudentID}");
            return student.FirstOrDefault();
        }
    }
}
