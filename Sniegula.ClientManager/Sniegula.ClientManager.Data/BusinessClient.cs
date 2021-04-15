using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.ClientManager.Data
{
    public class BusinessClient : Client
    {
        public static decimal DISCOUNT_NUMBER = 0.25M; 
        public string Nip { get; set; }

        public override string ToString()
        {
            // string message = base.ToString(); odwołanie do metod z klasy rodzica

            string message = "Klient biznesowy - > ";
            message = message + "ID:" + Id + " " + Name + " "+ " Kwota: " + OrderPrice;
            return message;
        }

        public static decimal CalculateDiscount (decimal orderValue) {

            return orderValue * BusinessClient.DISCOUNT_NUMBER;
        }

        public override void getsDiscount()
        {
            Console.WriteLine("Zniżka się należy");
        }
    }
}
