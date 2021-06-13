using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.Data
{
    public class Product : CsvPrintable
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public void FillValues(string line)
        {
            string[] splittedLine = line.Split(',');

            this.Name = splittedLine[0];
            this.Price = decimal.Parse( splittedLine[1]);
        }

        public string GetHeader()
        {
            return "Name, Price";
        }

        public string ToCsvString()
        {
            return Name + ", " + Price;
        }
    }
}
