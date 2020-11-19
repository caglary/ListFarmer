using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entity.Abstract
{
    public interface IUser
    {
         string Name { get; set; }
         string Password { get; set; }
         bool Add_Authority { get; set; }
         bool Delete_Authority { get; set; } 
         bool Update_Authority { get; set; } 
         bool Backup_Authority { get; set; }
         bool Restore_Authority { get; set; }
         bool Excel_Authority { get; set; }
    }
}
