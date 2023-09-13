using NPOI.SS.Formula.Functions;
using TestMVC.Models;

namespace TestMVC.Session
{
    public class AccountService : IAccountService
    {
        private List<Login> accounts;
        public AccountService() 
        { 
            accounts = new List<Login>()
            {
                new Login()
                {
                    Account="admin",
                    Password="123456"
                },
                new Login()
                {
                    Account = "admin1",
                    Password="123456"
                }
            };
        }
        public Login Login(string account, string password)
        {
            return accounts.SingleOrDefault(x => x.Account == account && x.Password == password);
        }
    }
}
