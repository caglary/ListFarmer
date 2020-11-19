using Entity.Concrete;
using System.Data.Entity.ModelConfiguration;
namespace Database.FluentApi
{
    public class DilekceMap : EntityTypeConfiguration<Dilekce>
    {
        public DilekceMap()
        {
            this.ToTable("Dilekceler");
            this.HasKey(I => I.DilekceId);
            this.Property(I => I.DilekceId)
                .HasColumnName("Dilekce ID")
                .HasColumnOrder(0);
            this.Property(I => I.DilekceNumarasi)
                .IsRequired()
                .HasColumnName("Dilekce Numarası")
                .HasColumnOrder(1);
            this.Property(I => I.DilekceTarihi)
               .HasColumnName("Dilekce Tarihi")
               .HasColumnOrder(2);
            this.Property(I => I.UretimYili)
               .IsRequired()
               .HasColumnName("Üretim Yılı")
               .HasColumnOrder(3)
               .HasMaxLength(4);
            this.Property(I => I.DilekceKabulTarihi)
               .HasColumnName("Dilekce Kabul Tarihi")
               .HasColumnOrder(4);
            this.Property(I => I.IlAdi)
               .HasColumnName("İl Adı")
               .HasColumnOrder(5)
               .HasMaxLength(20);
            this.Property(I => I.IlceAdi)
               .HasColumnName("İlçe Adı")
               .HasColumnOrder(6)
               .HasMaxLength(20);
            this.Property(I => I.Durum)
               .HasColumnName("Durum")
               .HasColumnOrder(7)
               .HasMaxLength(10);
            this.Property(I => I.CiftciId)
                .IsRequired()
                .HasColumnName("Çiftci ID")
                .HasColumnOrder(8);
            #region Relation
            this.HasRequired(I => I.Ciftci)
                .WithMany(I => I.Dilekce)
                .HasForeignKey(I => I.CiftciId);
            #endregion
        }
    }
}
