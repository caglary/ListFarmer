using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Database.FluentApi
{
    public class Mgd17Map : EntityTypeConfiguration<Mgd17>
    {
        public Mgd17Map()
        {
            this.ToTable("Mgd17");
        }
    }
}
