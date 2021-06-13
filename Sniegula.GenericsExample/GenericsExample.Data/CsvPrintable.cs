using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.Data
{
    public interface CsvPrintable
    {
         string ToCsvString();

         string GetHeader();

         void FillValues(string line);
    }
}
