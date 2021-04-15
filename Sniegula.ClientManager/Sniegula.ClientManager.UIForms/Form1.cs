using System;
using System.Collections.Generic;
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
            clientManager.GenerateInitialList();
            List<Client> initialClients = clientManager.GetAllClients();
            showClients(initialClients);

        }


        private void showClients(List<Client> clientList) {

            listBox1.Items.Clear();
            foreach (Client client in clientList) {

                listBox1.Items.Add(client);
            }
        }
    }
}
