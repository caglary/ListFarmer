using Entity.Concrete;
using System.Data.Entity.ModelConfiguration;
namespace Database.Context
{
    public class Fks19Map : EntityTypeConfiguration<Fks19>
    {
        public Fks19Map()
        {
            this.ToTable("Fks2019");
        }
    }
}