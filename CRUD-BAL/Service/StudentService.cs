using CRUD_DAL.Interface;
using CRUD_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_BAL.Service
{
    public class StudentService
    {
        private readonly IRepositoryStudent<StudentDetails> _studentDetails;

        public StudentService(IRepositoryStudent<StudentDetails> studentRepository)
        {
            _studentDetails = studentRepository;
        }
        /// <summary>
        /// This is to post the new student
        /// </summary>
        /// <param name="studentDetails"></param>
        /// <returns></returns>
        public async Task<StudentDetails> AddStudent(StudentDetails studentDetails)
        {
            return await _studentDetails.Create(studentDetails);
        }

        public IEnumerable<StudentDetails> GetStudentByStudentId(int StudentId)
        {
            return _studentDetails.GetAll().Where(x => x.studentid == StudentId).ToList();
        }
        //GET All Perso Details 
        public IEnumerable<StudentDetails> GetAllStudent()
        {
            try
            {
                return _studentDetails.GetAll().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
       
    }
}