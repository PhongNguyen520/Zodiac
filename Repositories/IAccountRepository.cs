using BusinessObjects;
using DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAccountRepository
    {
        public bool AddAccount(Account account);

        public bool DelAccounts(int id);

        public List<Account> GetAccounts();

        public bool UpdateAccounts(Account account);
    }
}
