using BusinessObjects;
using DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountDAO accountDAO = null;

        public AccountRepository()
        {
            if (accountDAO == null)
            {
                accountDAO = new AccountDAO();
            }
        }

        public bool AddAccount(Account account)
        {
            return accountDAO.AddAccount(account);
        }

        public bool DelAccounts(int id)
        {
            return accountDAO.DelAccounts(id);
        }

        public List<Account> GetAccounts()
        {
            return accountDAO.GetAccounts();
        }

        public bool UpdateAccounts(Account account)
        {
            return accountDAO.UpdateAccounts(account);
        }
    }
}
