using Entity.Concrete;
using System.Data.Entity.ModelConfiguration;
namespace Database.Context
{
    public class Mgd19Map : EntityTypeConfiguration<Mgd19>
    {
        public Mgd19Map()
        {
            this.ToTable("Mgd19");
        }
    }
}