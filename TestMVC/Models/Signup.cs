using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TestMVC.MvcEduModels;
using BCrypt.Net;

namespace TestMVC.Models
{
    public class Signup
    {
        private readonly MvcEduContext _context;
        public Signup(MvcEduContext context)
        {
            _context = context;
        }
        public class User
        {
            
        }
        public bool CheckAccount(string account)
        {
            if (string.IsNullOrEmpty(account))
            {
                return false;
            }

            bool exists = _context.Members.Any(m => m.Account == account);
            return !exists;
        }
        public bool Register(Member member,IFormFile Photo)
        {
            bool sign = false;
            bool reg = true;
            try
            {
                if (CheckAccount(member.Account))//檢查帳號是否重複
                {
                    sign = true;
                }
                else
                {
                    sign = false;
                }

                if (sign)
                {
                    int min = 0;
                    int max = 255;
                    int inde = 0;
                    Member members = new Member();
                    members.Account = member.Account;
                    var IDIndex = _context.Members.Max(u => u.ID); //找出最後一個ID 
                    if (IDIndex != 0)
                    {
                        inde = IDIndex;//找到ID +1
                        inde++;
                    }
                    else
                    {
                        inde = 0;
                    }
                    members.ID = inde;
                    members.JoinDate = DateTime.Now;
                    members.Fee = 0;
                    members.Membership = "";
                    members.UserName = member.UserName;
                    members.Education = member.Education;
                    members.Email = member.Email;
                    string passsalt = member.Password;
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(passsalt, salt);
                    members.Password = hashedPassword;
                    if (Photo != null && Photo.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            Photo.CopyTo(memoryStream);
                            byte[] photoBytes = memoryStream.ToArray();
                            members.Photo = photoBytes;
                            // 现在，photoBytes 包含了文件的字节数据，你可以在这里进行处理
                        }
                    }
                    
                    members.Gender = member.Gender;
                    members.Address = member.Address;
                    if (member.Telephone != null)
                    {
                        members.Telephone = member.Telephone;
                    }
                    else
                    {
                        members.Telephone = "";
                    }
                    if (member.Cellphone != null)
                    {
                        members.Cellphone = member.Cellphone;
                    }
                    else
                    {
                        members.Cellphone = "";
                    }
                    if (member.LineID != null)
                    {
                        members.LineID = member.LineID;
                    }
                    else
                    {
                        members.LineID = "";

                    }
                    _context.Members.Add(members);
                    _context.SaveChanges();
                    reg =  true;
                }
                else
                {
                    reg = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return reg;
        }


    }
}
