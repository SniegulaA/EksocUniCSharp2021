using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.GenericsExample.Logic.FileOperations.GenericsWithReflections
{
    public class FileReaderWithGenericsWithReflection<T> where T : class, new()
    {
        public List<T> ReadPeopleFromFile(string fileName)
        {

            List<T> people = new List<T>();

            List<string> lines = File.ReadAllLines(fileName).ToList();
            //Pobrać nagłówki
            T entry = new T();
            Type mytype = entry.GetType();
            List<PropertyInfo> properties = mytype.GetProperties().ToList();
            string firstLine = lines[0];
            string[] headerNames = firstLine.Split(',');
            for (int i =0; i< headerNames.Length; i++) {
                headerNames[i] = headerNames[i].Trim();
            }


            lines.RemoveAt(0);

            for (int i=0; i< lines.Count; i++)
            {
                //Iteruję po linijkach pliku

                T p = new T();
                string[] splittedLine = lines[i].Split(',');

                for (int j = 0; j < headerNames.Length; j++) {
                    //Iteruję po kolumnach w pliku


                    foreach (PropertyInfo propertyInfo in properties) {
                        //Iterujemy po parametrach klasy
                        //Szukamy parametru dla którego nazwa == nazwą headera

                        if (headerNames[j].Equals(propertyInfo.Name)) {
                            string value = splittedLine[j];
                            Type propertyType = propertyInfo.PropertyType;
                            propertyInfo.SetValue(p, Convert.ChangeType(value, propertyType) );
                        }
                    }

                }


                people.Add(p);
            }


            return people;

        }
    }
}
