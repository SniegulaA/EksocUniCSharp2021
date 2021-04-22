using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.StudentManager.Data
{
    public class Student
    {

        private string name;

        public List<Note> Notes { get; set; }
        public string Name { get { return name; }set { name = value; } }
        public string Surname { get; set; }

       public Student(string name, string surmane)
        {
         
            this.name = name;
            this.Surname = surmane;
            Notes = new List<Note>();
            Console.WriteLine("Utworzono nowy obiekt {0} {1}", this.Name, Surname);

        }

        public Student() { 
        
        }

        public Student(int a, string b, List<Note> c) { 
        
        }

        ~Student() {

            Console.WriteLine("Obiekt jest niszczony {0} {1}" , this.Name, Surname);
        
        }



    }
}
