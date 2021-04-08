using Sniegula.SellsManager.Data;
using Sniegula.SellsManager.Logic.Common;
using Sniegula.SellsManager.Logic.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniegula.SellsManager.UIForms
{
    public partial class Form1 : Form
    {
        List<Transaction> allTransactions = new List<Transaction>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CsvFileReader reader = new CsvFileReader();
            allTransactions = reader.ReadFile();
            showTransactions(allTransactions);



        }


        private void showTransactions(List<Transaction> transactionsList) {
            ListBox listBox = listBox1;
            listBox1.Items.Clear(); //Wyczyszczenie zawartości kontrolki typu ListBox
            for (int i = 0; i < transactionsList.Count; i++)
            {
                listBox.Items.Add(transactionsList[i]);
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            //1 Pobranie nazwy handlowca z text boxa
            string tradeName = textBoxTrader.Text;
            //2 Utworzenie obiektu typu TransactionFilter
            TransactionFIlter transactionFIlter = new TransactionFIlter();
            //3 UStawienie parametru filtrowania
            transactionFIlter.TraderName = tradeName;

            CheckBox selledGreaterThenOrEqual = checkBoxSelledNumberGreaterThan;
            bool userWantsToFIlterBySelledGreaterThenOrEqual = selledGreaterThenOrEqual.Checked;
            if (userWantsToFIlterBySelledGreaterThenOrEqual) {
                transactionFIlter.NumberOfSelledItemsGreaterOrEqual = (int?)numericUpDownSelledItemsGreaterThan.Value;
            }

            TextBox selledLessThenOrEqual = textBoxSelledNumberLessThen;
            string selledLessThenOrEqualTextValue = selledLessThenOrEqual.Text;

            //4 Utworznie obikeu typu klasu serwisowej TransactionService
            TransactionsService transactionsService = new TransactionsService();
            //5 Wywołanie funkcji filtrującej
            List<Transaction> filteredTransactions = transactionsService.FilterTransactions(allTransactions, transactionFIlter);
            //6 Zaimplementowanie filtrowania wewnątrz TransactionService
            //7 Wyśietlenie wyniku działania funkcji na ekran
            showTransactions(filteredTransactions);

        }
    }
}
