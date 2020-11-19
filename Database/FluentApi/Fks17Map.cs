using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Database.FluentApi
{
    public class Fks17Map : EntityTypeConfiguration<Fks17>
    {
        public Fks17Map()
        {
            this.ToTable("Fks2017");
        }
    }
}
