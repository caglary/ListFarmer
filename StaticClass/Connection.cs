using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StaticClass
{
    public static class Connection
    {
        public static string ConnectionString()
        {
           return @"data source=.;initial catalog=Test;User Id=sa;Password=1;";
        }
    }
}
