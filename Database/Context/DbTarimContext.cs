using Database.FluentApi;
using Entity.Concrete;
using System.Data.Entity;
namespace Database.Context
{
    public class DbTarimContext : DbContext
    {
       
        public DbTarimContext() : base(StaticClass.Connection.ConnectionString())
        {
        }
        public DbSet<Ciftci> Ciftciler { get; set; }
        public DbSet<Dilekce> Dilekceler { get; set; }
     
        public DbSet<Fks18> Fks18Listesi { get; set; }
        public DbSet<Fks19> Fks19Listesi { get; set; }
        public DbSet<Fks17> Fks17Listesi { get; set; }
        public DbSet<Mgd18> Mgd18Listesi { get; set; }
        public DbSet<Mgd19> Mgd19Listesi { get; set; }
        public DbSet<Mgd17> Mgd17Listesi { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CiftciMap());
            modelBuilder.Configurations.Add(new DilekceMap());
            modelBuilder.Configurations.Add(new Fks18Map());
            modelBuilder.Configurations.Add(new Fks17Map());
            modelBuilder.Configurations.Add(new Fks19Map());
            modelBuilder.Configurations.Add(new Mgd18Map());
            modelBuilder.Configurations.Add(new Mgd19Map());
            modelBuilder.Configurations.Add(new Mgd17Map());
            modelBuilder.Entity<Ciftci>().HasIndex(ciftci => new { ciftci.Tc }).IsUnique(true);
        }
    }
   
}
