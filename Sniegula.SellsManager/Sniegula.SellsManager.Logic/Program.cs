using Sniegula.SellsManager.Data;
using Sniegula.SellsManager.Logic.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.SellsManager.Logic
{
    class Program
    {
        static void Main(string[] args)
        {

            CsvFileReader reader = new CsvFileReader();
            List<Transaction> transactions = new List<Transaction>();
            transactions = reader.ReadFile();

            Console.WriteLine(transactions.Count);

            Console.ReadKey();
        }
    }
}
