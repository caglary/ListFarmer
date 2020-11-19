using Entity.Concrete;
using System.Data.Entity.ModelConfiguration;
namespace Database.FluentApi
{
    public class CiftciMap : EntityTypeConfiguration<Ciftci>
    {
        public CiftciMap()
        {
            this.ToTable("Ciftciler");
            this.HasKey(I => I.Id);
            this.Property(I => I.Id).HasColumnName("Ciftci ID").HasColumnOrder(1);
            this.Property(I => I.Tc).HasColumnName("TC Numarası").HasColumnOrder(2).IsRequired().HasMaxLength(11);
            this.Property(I => I.Isim).HasColumnName("Isim").HasColumnOrder(3).IsRequired();
            this.Property(I => I.Soyisim).HasColumnName("Soyisim").HasColumnOrder(4).IsRequired();
            this.Property(I => I.Mahalle).HasColumnName("Mahalle").HasColumnOrder(5).IsRequired();
            this.Property(I => I.Telefon).HasColumnName("Telefon").HasColumnOrder(6).IsOptional();
            this.Property(I => I.Aciklama).HasColumnName("Acıklama").HasColumnOrder(7).HasColumnType("ntext").IsOptional();
            this.Property(I => I.KayitTarih).HasColumnName("Kayıt Tarihi").HasColumnOrder(8).IsRequired();
            this.Property(I => I.OlumTarihi).HasColumnName("Ölüm Tarihi").HasColumnOrder(9).IsOptional();
          
        }
    }
}
