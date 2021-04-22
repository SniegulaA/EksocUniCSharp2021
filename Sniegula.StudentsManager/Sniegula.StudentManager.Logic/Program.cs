using Sniegula.StudentManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.StudentManager.Logic
{
    class Program
    {
        static void Main(string[] args)
        {
           
            UseStudentsService();

            GC.Collect();

            Console.WriteLine("Wielkość programu {0}", GC.GetTotalMemory(true));

            Console.ReadLine();

        }

        public static void UseStudentsService() {
            StudentService studentService = new StudentService();
            studentService.Initialize();
            Student n = studentService[0];
            Console.WriteLine("pierwszy student na liście {0} {1}", n.Name, n.Surname);

            Console.WriteLine("Wielkość programu {0}", GC.GetTotalMemory(false));
        }
    }
}
