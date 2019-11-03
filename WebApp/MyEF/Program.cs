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
               Address ="Dhanmondi",
               Age = 35

           };
           if (_studentManager.Add(student))
            {
               Console.WriteLine("Save Success");
            }
           else
           {
               Console.WriteLine("Fail Save!");
           }

           Console.ReadKey();



        }
    }
}
