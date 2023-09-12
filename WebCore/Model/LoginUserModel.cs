using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCore.Model
{
    internal class LoginUserModel
    {
        public class LoginModel
        {
            /// <summary>
            /// 名子
            /// </summary>
            public string Name { get; set; } 
            /// <summary>
            /// 密碼
            /// </summary>
            public string Password { get; set; }
        }
    }
}
