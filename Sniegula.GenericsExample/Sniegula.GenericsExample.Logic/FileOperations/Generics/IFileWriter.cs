using GenericsExample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.GenericsExample.Logic.FileOperations.Generics
{
    public interface IFileWriter<T> 
    {
         void SaveToFile(string fileName, List<T> people);
    }
}
