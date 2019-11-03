using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.BLL.BLL;

namespace MyEF
{
    class Program
    {
        static void Main(string[] args)
        {
           StudentManager _studentManager = new StudentManager();
            Student student = new Student()
            {
                RollNo = "001",
                Name = "Khaleed Al-Amran",
                Address = "Dhanmondi",
                Age = 35

            };
            //if (_studentManager.Add(student))
            // {
            //    Console.WriteLine("Save Success");
            // }
            //else
            //{
            //    Console.WriteLine("Fail Save!");
            //}

            //Delete
            //if (_studentManager.Delete(1))
            //{
            //    Console.WriteLine("Delete Success");
            //}
            //else
            //{
            //    Console.WriteLine("Fail Delet!");
            //}



            Console.ReadKey();

            //Update
            
            student.Id = 2;

            student.Name = "Md. Khaleed Al-Amran";
            student.Address = "Khulna";
            student.Age = 36;

            //if (_studentManager.Update(student))
            //{
            //    Console.WriteLine("Update Success");
            //}
            //else
            //{
            //    Console.WriteLine("Fail Update!");
            //}

            var students = _studentManager.GetAll();
            var aStudent = _studentManager.GetById(3);
            Console.ReadKey();
        }
    }
}
