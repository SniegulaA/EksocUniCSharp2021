using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.Data
{
    public class Person : CsvPrintable
    {
        public Person() { 
        }

        public Person(string name, string surname) {

            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public void FillValues(string line)
        {
            string[] splittedLine = line.Split(',');

            this.Name = splittedLine[0];
            this.Surname = splittedLine[1];
        }

        public string GetHeader()
        {
            return "Name, Surname";
        }

        public string ToCsvString()
        {
            return Name + ", " + Surname;
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }


    }
}
