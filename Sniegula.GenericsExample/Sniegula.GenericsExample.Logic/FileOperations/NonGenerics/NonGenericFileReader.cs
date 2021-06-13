using GenericsExample.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.GenericsExample.Logic.FileOperations.NonGenerics
{
    public class NonGenericFileReader
    {

        public  List<Person> ReadPeopleFromFile(string fileName) {

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(fileName).ToList();
            lines.RemoveAt(0);

            foreach (string line in lines) {
                Person p = new Person();
                string[] splittedLine = line.Split(',');

                p.Name = splittedLine[0];
                p.Surname = splittedLine[1];
                people.Add(p);
            }


            return people;

        }

        public  List<Product> ReadProductFromFile(string fileName)
        {

            List<Product> products = new List<Product>();

            List<string> lines = File.ReadAllLines(fileName).ToList();
            lines.RemoveAt(0);

            foreach (string line in lines)
            {
                Product p = new Product();
                string[] splittedLine = line.Split(',');

                p.Name = splittedLine[0];
                p.Price = decimal.Parse(splittedLine[1]);
                products.Add(p);
            }


            return products;

        }
    }
}
