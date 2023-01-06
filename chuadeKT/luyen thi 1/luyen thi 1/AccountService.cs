using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luyen_thi_1
{

    class AccountService
    {
        private List<Account> Accounts;
        private List<Role> lstRoles;
        private DatabaseContext dbcontext;
        public AccountService()
        {

            Accounts = new List<Account>();

            dbcontext = new DatabaseContext();
            getAccountDbFromDB();
            lstRoles = dbcontext.Roles.ToList();
        }
        public List<Role> getlstlstRoles()
        {
            return lstRoles;
        }
        public List<Account> getlstAccount()
        {
            return Accounts;
        }
        private void getAccountDbFromDB()
        {
            //bang Account
            Accounts = dbcontext.Account.ToList();
            //xuất ra màn
        }

        public string addaccountts(Account acc)
        {
            // bang Account
            dbcontext.Account.Add(acc);
            dbcontext.SaveChanges();
            return "them thanh cong";
        }
        public string UpdateAccounts(Account acc)
        {
            // bang Account
            dbcontext.Account.Add(acc);
            dbcontext.SaveChanges();
            return "them thanh cong";
        }
        public string DeleteAccount(Guid id)
        {
            var acc = dbcontext.Account.FirstOrDefault(c => c.Id == id);
            dbcontext.Account.Remove(acc);
            dbcontext.SaveChanges();
            return "Xóa thanh cong";
        }
        public string add(string acc)
        {
            return Accounts.Where(C => C.acc.StartsWith(acc)).ToList();
        }
    }
}
