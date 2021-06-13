using GenericsExample.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.GenericsExample.Logic.FileOperations.NonGenerics
{
    public class NonGenericFileWriter
    {

        public void SavePeopleToFile(string fileName, List<Person> people) {

            if (!File.Exists(fileName)) {

                using (FileStream stream = File.Create(fileName))
                using (StreamWriter streamWriter = new StreamWriter(stream)) {

                    streamWriter.WriteLine("Name, Surname");


                    foreach (Person o in people) {

                        streamWriter.WriteLine(o.Name + ", " + o.Surname);
                    }


                }
            }
        }

        public void SaveProductToFile(string fileName, List<Product> products)
        {

            if (!File.Exists(fileName))
            {

                using (FileStream stream = File.Create(fileName))
                using (StreamWriter streamWriter = new StreamWriter(stream))
                {

                    streamWriter.WriteLine("Name, Price");


                    foreach (Product o in products)
                    {

                        streamWriter.WriteLine(o.Name + ", " + o.Price);
                    }


                }
            }
        }
    }
}
