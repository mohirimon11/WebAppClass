﻿using System;
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
        public bool Delete(int id)
        {
            Student aStudent = _dbContext.Students.FirstOrDefault(c => c.Id == id);
             _dbContext.Students.Remove(aStudent);
             return _dbContext.SaveChanges() > 0;
        }
        public bool Update(Student student)
        {
            Student aStudent = _dbContext.Students.FirstOrDefault((c => c.Id ==student.Id ));
            if (aStudent != null)
            {
                aStudent.RollNo = student.RollNo;
                aStudent.Name = student.Name;
                aStudent.Address = student.Address;
                aStudent.Age = student.Age;

            }
            return _dbContext.SaveChanges()>0;
        }

        public List<Student> GetAll()
        {

            return _dbContext.Students.ToList();
        }

        public Student GetById(int id)
        {
            
            return _dbContext.Students.FirstOrDefault(c=>c.Id==id);
        }
    }
}
