using GenericsExample.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.GenericsExample.Logic.FileOperations.Generics
{
    public class FileWriterWithGenerics<T> : IFileWriter<T> where T: CsvPrintable
    {
    

        public void SaveToFile(string fileName, List<T> people)
        {

            if (!File.Exists(fileName))
            {

                using (FileStream stream = File.Create(fileName))
                using (StreamWriter streamWriter = new StreamWriter(stream))
                {

                    /*T obj = people[0];
                    Type type = obj.GetType();
                    //if(type == typeof(Person))
                    if (obj is Person)
                    {
                        streamWriter.WriteLine("Name, Surname");
                    }*/

                    T obj = people[0];
                    streamWriter.WriteLine(obj.GetHeader());

                    foreach (T o in people)
                    {                     
                            streamWriter.WriteLine(o.ToCsvString());
                        
                    }


                }
            }
        }

        public void SaveToFile(string fileName, List<Person> people)
        {
            throw new NotImplementedException();
        }
    }
}
