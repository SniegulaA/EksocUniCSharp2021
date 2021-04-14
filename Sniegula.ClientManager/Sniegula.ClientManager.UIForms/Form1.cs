using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sniegula.ClientManager.Data;
using Sniegula.ClientManager.Logic;
namespace Sniegula.ClientManager.UIForms
{
    public partial class Form1 : Form
    {

        ClientService clientManager = new ClientService();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clientManager.generateInitialList();
            List<Client> initialClients = clientManager.GetAllClients();
            showClients(initialClients);

        }


        private void showClients(List<Client> clientList) {

            foreach (Client client in clientList) {

                listBox1.Items.Add(client);
            }
        }
    }
}
