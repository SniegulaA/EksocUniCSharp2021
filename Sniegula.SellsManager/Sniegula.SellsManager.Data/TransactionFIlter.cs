using System;
using System.Collections.Generic;
using System.Text;

namespace Sniegula.SellsManager.Data
{
    public class TransactionFIlter
    {
        public string TraderName { get; set; }
        public int? NumberOfSelledItemsGreaterOrEqual { get; set; }
        public int? NumberOfSelledItemsLessOrEqual { get; set; }

        //Dodatkowe parametry (produkt, miejscowość)

    }
}
