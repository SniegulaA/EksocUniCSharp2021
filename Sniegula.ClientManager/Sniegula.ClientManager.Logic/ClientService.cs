using Sniegula.ClientManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.ClientManager.Logic
{
    public class ClientService
    {
        private List<Client> clients = new List<Client>();

        public void GenerateInitialList() {

            Client c1 = new Client();
            c1.Age = 18;
            c1.Name = "Tomasz";
            c1.Surname = "Kowalski";
            c1.OrderPrice = 0;
            clients.Add(c1);

            Client c2 = new Client();
            c2.Age = 20;
            c2.Name = "Joanna";
            c2.Surname = "Weselska";
            c2.OrderPrice = 100;
            clients.Add(c2);

            Client c3 = new Client();
            c3.Age = 30;
            c3.Name = "Karol";
            c3.Surname = "Ignaciuk";
            c3.OrderPrice = 3;
            clients.Add(c3);


        }

        public List<Client> GetAllClients() {
            return clients;
        
        }
    }
}
