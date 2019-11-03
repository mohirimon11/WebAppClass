using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.DatabaseContext.DatabaseContext;
namespace WebApp.Repository.StudentRepository
{
    public class StudentRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public bool Add(Student student)
        {
            _dbContext.Students.Add(student);
       

            return _dbContext.SaveChanges()>0;
        }
        public bool Delete(Student student)
        {
            return true;
        }
        public bool Update(Student student)
        {
            return true;
        }

        public List<Student> GetAll()
        {
            List<Student> student = new List<Student>();
            return student;
        }

        public Student GetById(int id)
        {
            Student student = new Student();
            return student;
        }
    }
}
