
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoadDwhVenta.Data.Entities.DwVentas.Configurations
{
    public partial class DimProductConfiguration : IEntityTypeConfiguration<DimProduct>
    {
        public void Configure(EntityTypeBuilder<DimProduct> entity)
        {
            entity.HasKey(e => e.ProductKey).HasName("PK__DimProdu__A15E99B3CF50527C");

            entity.ToTable("DimProduct");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DimProduct> entity);
    }
}
