using Sniegula.StudentManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.StudentManager.Logic
{
    public class StudentService
    {
        List<Student> students = new List<Student>();

        public Student this[int i] {
            get {
                if (i >= 0 && i < students.Count)
                {
                    return students[i];
                }
                else {

                    return null;
                }
            }
            set {
                if (i >= 0 && i < students.Count)
                {
                    students[i] = value;
                }
            }
        
        
        }

        public void Initialize()
        {
            Student s1 = new Student("Jan", "Kowalski");
            Note n1 = new Note("MATEMATYKA", 3);
            Note n2 = new Note("CHEMIA", 4);
            s1.Notes.Add(n1);
            s1.Notes.Add(n2);

            Student s2 = new Student("Joanna", "Jasińska");
            Note n3 = new Note("POLSKI", 5);
            s2.Notes.Add(n3);

            Student s3 = new Student("Paweł", "Rogucki");

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
        }

        public List<Student> GetAllStudents() {
            return students;


        }

    }
           
}
