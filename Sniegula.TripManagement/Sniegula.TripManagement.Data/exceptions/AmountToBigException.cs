using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.TripManagement.Data.exceptions
{
    public class AmountToBigException :Exception
    {
        public AmountToBigException(string message) : base(message)
        {
        }

        public AmountToBigException(string message, decimal maximalAmount) : base(message)
        {
            MaximalAmount = maximalAmount;
        }

        public decimal MaximalAmount { get; set; }

    
    }
}
