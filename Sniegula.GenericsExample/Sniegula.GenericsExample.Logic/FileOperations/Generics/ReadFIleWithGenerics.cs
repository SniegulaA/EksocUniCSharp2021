using GenericsExample.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.GenericsExample.Logic.FileOperations.Generics
{
    public class ReadFIleWithGenerics<T> where T:CsvPrintable, new()
    {
        public List<CsvPrintable> ReadCsvPrintableFromFile(string fileName)
        {

            return new List<CsvPrintable>();
        }


        public List<object> ReadObjectFromFile(string fileName) {

            return new List<object>();
        }

        public List<T> ReadPeopleFromFile(string fileName)
        {

            List<T> people = new List<T>();

            List<string> lines = File.ReadAllLines(fileName).ToList();
            lines.RemoveAt(0);

            foreach (string line in lines)
            {
      
                T p = new T();
                p.FillValues(line);
                people.Add(p);
            }


            return people;

        }
    }
}
