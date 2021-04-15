using Sniegula.ClientManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.ClientManager.Logic
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Client> clients = new List<Client>();

            Client clientA = new Client();
            clientA.Name = "Tomasz";
            clientA.Surname = "Kowalski";
            clientA.Age = 20;
            clientA.Id = 1;
            clients.Add(clientA);


            BusinessClient businessClient = new BusinessClient();
            businessClient.Id = 2;
            businessClient.Name = "Firma A";
            businessClient.Nip = "abcd-efg-jklm";
            decimal discount = BusinessClient.DISCOUNT_NUMBER;
            BusinessClient.DISCOUNT_NUMBER = 0.3M;


            clients.Add(businessClient);



            foreach (Client client in clients) {
                Console.WriteLine(client.ToString());

                if (client.GetType() == typeof(BusinessClient))
                {

                    Console.WriteLine("Klient biznesowy, nalicz zniżkę " + "Z zastosowaniem GETTYPE/typeof");
                }

                if (client is BusinessClient) {

                    Console.WriteLine("Klient biznesowy " + "Z zastosowaniem is");
                }

            }

            Console.WriteLine("Zniżka dla firm " + BusinessClient.DISCOUNT_NUMBER);
            decimal calculatedDiscount = BusinessClient.CalculateDiscount(100);

            Console.WriteLine("Zniżka dla 100 zł " + calculatedDiscount);
            Console.ReadKey();

        }
    }
}
