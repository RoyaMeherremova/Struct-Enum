
using Service.Helpers.Constans;
using Service.Helpers.Enums;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class Account : IAccount
    {
        public string Login(string username, string password, int roles)
        {
            if(username=="test@code.edu.az" && password=="test12345" && roles==(int)Roles.SuperAdmin)
            {
                return "Giris ugurludur";
            }
           
            else if (roles != (int)Roles.SuperAdmin)
            {
                return Errors.LoginErrorRole;
            }
            
              return Errors.LoginErrorMailPassword;
            
        }
    }
}
