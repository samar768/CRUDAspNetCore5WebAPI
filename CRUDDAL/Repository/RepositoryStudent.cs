using CRUD_DAL.Data;
using CRUD_DAL.Interface;
using CRUD_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DAL.Repository
{
    public class RepositoryStudent : IRepositoryStudent<StudentDetails>
    {
        ApplicationDbContext _dbContext;
        public RepositoryStudent(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<StudentDetails> Create(StudentDetails _object)
        {
            try
            {
                var obj = await _dbContext.StudentDetails.AddAsync(_object);
                _dbContext.SaveChanges();
                return obj.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(StudentDetails _object)
        {
            _dbContext.Remove(_object);
            _dbContext.SaveChanges();
        }

        public IEnumerable<StudentDetails> GetAll()
        {
            try
            {
                return _dbContext.StudentDetails.ToList();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public StudentDetails GetById(int Id)
        {
            return _dbContext.StudentDetails.Where(x => x.studentid == Id).FirstOrDefault();
        }

        public void Update(StudentDetails _object)
        {
            _dbContext.StudentDetails.Update(_object);
            _dbContext.SaveChanges();
        }

    }
}

