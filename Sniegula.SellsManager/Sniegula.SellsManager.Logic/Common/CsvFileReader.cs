using Sniegula.SellsManager.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.SellsManager.Logic.Common
{
    public class CsvFileReader
    {
        public List<Transaction> ReadFile()
        {

            List<Transaction> tranactions = new List<Transaction>();
            string fileName = "kosmetyki.csv";

            string[] readarray = File.ReadAllLines(fileName, Encoding.UTF8);



            for (int i = 0; i < readarray.Length; i++)
            {

                if (i > 0)
                {

                    string line = readarray[i];
                    string[] splittedLine = line.Split(';');
                    string trader = splittedLine[0];
                    int month = int.Parse(splittedLine[1]);
                    string product = splittedLine[2];
                    int numberOfSelledProducts = int.Parse(splittedLine[3]);
                    int sellPrice = int.Parse(splittedLine[4]);
                    string province = splittedLine[5];

                    Transaction t = new Transaction();
                    t.Trader = trader;
                    t.Month = month;
                    t.NumberOfSelledItems = numberOfSelledProducts;
                    t.Product = product;
                    t.Province = province;
                    t.ValueOfSelledItems = sellPrice;
                    tranactions.Add(t);

                }

            }
            return tranactions;

        }


    }
}
