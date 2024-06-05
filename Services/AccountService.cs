using BusinessObjects;
using DAOs;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService
    {
        private readonly IAccountRepository iAccountRepository = null;

        public AccountService()
        {
            if (iAccountRepository == null)
            {
                iAccountRepository = new AccountRepository();
            }
        }

        public bool AddAccount(Account account)
        {
            return iAccountRepository.AddAccount(account);
        }

        public bool DelAccounts(int id)
        {
            return iAccountRepository.DelAccounts(id);
        }

        public List<Account> GetAccounts()
        {
            return iAccountRepository.GetAccounts();
        }

        public bool UpdateAccounts(Account account)
        {
            return iAccountRepository.UpdateAccounts(account);
        }
    }
}
