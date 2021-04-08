using Sniegula.SellsManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.SellsManager.Logic.Service
{
    public class TransactionsService
    {
        public List<Transaction> FilterTransactions(List<Transaction> transactions, TransactionFIlter transactionFilter) {

            List<Transaction> filteredTransactions = new List<Transaction>();
            foreach(Transaction t in transactions){
                if (t.Trader == transactionFilter.TraderName) {
                    filteredTransactions.Add(t);
                }
            }



            return filteredTransactions;
        }
    }
}
