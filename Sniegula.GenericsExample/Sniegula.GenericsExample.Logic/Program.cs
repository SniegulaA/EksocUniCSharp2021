using GenericsExample.Data;
using Sniegula.GenericsExample.Logic.FileOperations.Generics;
using Sniegula.GenericsExample.Logic.FileOperations.GenericsWithReflections;
using Sniegula.GenericsExample.Logic.genericsFirstExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.GenericsExample.Logic
{
    class Program
    {
        static void Main(string[] args)
        {

            //Example1
            /*
             Example1 example1 = new Example1();
             example1.ExampleList();*/



            string fileName = "files/People2.csv";


            //Example 2 -read file with generics
            /*
            ReadFIleWithGenerics<Person> reader = new ReadFIleWithGenerics<Person>();
            List<Person> peopleFromFile = reader.ReadPeopleFromFile(fileName);

            //Nieoptymalne - musimy rzutować
            List<object> listFromFile = reader.ReadObjectFromFile(fileName);
            foreach (object obj in listFromFile)
            {
                if (obj is Person)
                {
                    Person person = (Person)obj;
                }
            } 
            
            //Nieoptymalne - musimy rzutować
            List<CsvPrintable> listPrintableFromFile = reader.ReadCsvPrintableFromFile(fileName);
            foreach (CsvPrintable obj in listPrintableFromFile)
            {
                if (obj is Person)
                {
                    Person person = (Person)obj;
                }
            }

            */



            List<Person> people = new List<Person>();
            Person p1 = new Person();
            p1.Name = "Jan";
            p1.Surname = "Kowalski";

            Person p2 = new Person();
            p2.Name = "Joanna";
            p2.Surname = "Kowalska";

            people.Add(p1);
            people.Add(p2);


             FileWriterWithGenericsWithReflection<Person> writerWithReflection =
                 new FileWriterWithGenericsWithReflection<Person>();

              writerWithReflection.SaveToFile(fileName, people);

            FileReaderWithGenericsWithReflection<Person> readFile
                = new FileReaderWithGenericsWithReflection<Person>();

            List<Person> peopleFromFile = readFile.ReadPeopleFromFile(fileName);
            foreach (Person p in peopleFromFile) {

                Console.WriteLine(p.ToString());
            }


            
        

            Console.ReadLine();
        }
    }
}
