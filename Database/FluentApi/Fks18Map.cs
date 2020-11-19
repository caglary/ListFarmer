using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Database.FluentApi
{
   public class Fks18Map : EntityTypeConfiguration<Fks18>
    {
        public Fks18Map()
        {
            this.ToTable("Fks2018");
        }
    }
}
