using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StaticClass
{
    public static class UserClass
    {
        private static User _user;
        public static User WhichUser()
        {
            if (Environment.MachineName.ToLower() == "caglardesktop")
            {
                _user = new User
                {
                    Name = "ilce Tarim",
                    Password = "1",
                    Add_Authority = true,
                    Delete_Authority = true,
                    Backup_Authority = true,
                    Restore_Authority = true,
                    Update_Authority = true,
                    Excel_Authority = true
                };
                return _user;
            }
            else if (Environment.MachineName.ToLower() == "lenovo")
            {
                _user = new User
                {
                    Name = "Lenovo",
                    Password = "1",
                    Add_Authority = true,
                    Delete_Authority = true,
                    Backup_Authority = true,
                    Restore_Authority = true,
                    Update_Authority = true,
                    Excel_Authority = true
                };
                return _user;
            }
            else
            {
                _user = new User
                {
                    Name = "Guest",
                    Password = "",
                    Excel_Authority = true,
                    Backup_Authority = true
                };
                return _user;
            }
        }
        public static void UserAuthoritiesValidation(Action action, bool Authority)
        {
            if (Authority)
                action.Invoke();
            else
                StaticClass.MessageBoxOperation.Unauthorized();
        }
    }
}
