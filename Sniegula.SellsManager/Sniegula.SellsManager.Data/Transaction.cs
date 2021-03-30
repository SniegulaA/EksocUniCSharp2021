using System;
using System.Collections.Generic;
using System.Text;

namespace Sniegula.SellsManager.Data
{
    public class Transaction
    {
        private string trader;
        public string Trader {
            get { return trader; }
            set { trader = value; } 
        
        }

        public int Month { get; set; }
        public string Product { get; set; }
        public int NumberOfSelledItems { get; set; }
        public int ValueOfSelledItems { get; set; }
        public string Province { get; set; }


    }
}
