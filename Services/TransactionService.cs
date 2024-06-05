using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(TransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public bool AddTransaction(Transaction transaction)
        {
            return _transactionRepository.AddTransaction(transaction);
        }

        public bool DelTransactions(int id)
        {
            return _transactionRepository.DelTransactions(id);
        }

        public List<Transaction> GetTransactions()
        {
            return _transactionRepository.GetTransactions();
        }

        public bool UpdateTransactions(Transaction transaction)
        {
            return _transactionRepository.UpdateTransactions(transaction);
        }
    }
}
