using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.GenericsExample.Logic.FileOperations.Generics
{
    public class SomeOtherFileWriter : IFileWriter<string>, IComparable<SomeOtherFileWriter>
    {
        public int CompareTo(SomeOtherFileWriter other)
        {
            throw new NotImplementedException();
        }

        public void SaveToFile(string fileName, List<string> people)
        {
            throw new NotImplementedException();
        }
    }
}
