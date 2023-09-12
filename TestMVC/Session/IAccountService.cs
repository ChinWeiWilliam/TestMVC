using TestMVC.Models;

namespace TestMVC.Session
{
    public interface IAccountService
    {
        public Login Login(string account, string password);
    }
}
