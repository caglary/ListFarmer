using Entity.Concrete;
using System.Data.Entity.ModelConfiguration;
namespace Database.Context
{
    public class Mgd18Map : EntityTypeConfiguration<Mgd18>
    {
        public Mgd18Map()
        {
            this.ToTable("Mgd18");
        }
    }
}