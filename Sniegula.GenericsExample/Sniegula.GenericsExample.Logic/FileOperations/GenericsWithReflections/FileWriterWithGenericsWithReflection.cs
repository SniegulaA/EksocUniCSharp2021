using GenericsExample.Data;
using Sniegula.GenericsExample.Logic.FileOperations.Generics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.GenericsExample.Logic.FileOperations.GenericsWithReflections
{
    public class FileWriterWithGenericsWithReflection<T> : IFileWriter<T> 
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
                    Type type = obj.GetType();
                    List<PropertyInfo> properties = type.GetProperties().ToList();
                    properties.Sort((p, k) => String.Compare(p.Name, k.Name));
                    string header = "";
                    for (int i=0; i< properties.Count; i++) {

                        header += properties[i].Name;
                        if (i < properties.Count - 1) {
                            header += ", ";
                        }
                    }


                    streamWriter.WriteLine(header);

                    foreach (T o in people)
                    {
                        type = obj.GetType();
                        properties = type.GetProperties().ToList();
                        string dataRow = "";
                        for (int i = 0; i < properties.Count; i++)
                        {

                            dataRow += properties[i].GetValue(o);
                            if (i < properties.Count - 1)
                            {
                                dataRow += ", ";
                            }
                        }

                        streamWriter.WriteLine(dataRow);

                    }


                }
            }
        }
    }
}
