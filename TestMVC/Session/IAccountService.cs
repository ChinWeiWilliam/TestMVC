using TestMVC.Models;

namespace TestMVC.Session
{
    public interface IAccountService
    {
        //add interface 2023/09/12 22:48
        public Login Login(string account,string password);
    }
}
