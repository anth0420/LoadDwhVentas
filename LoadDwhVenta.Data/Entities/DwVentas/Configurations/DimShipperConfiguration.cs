
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoadDwhVenta.Data.Entities.DwVentas.Configurations
{
    public partial class DimShipperConfiguration : IEntityTypeConfiguration<DimShipper>
    {
        public void Configure(EntityTypeBuilder<DimShipper> entity)
        {
            entity.HasKey(e => e.ShipperKey).HasName("PK__DimShipp__503F471F0871CB54");

            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            entity.Property(e => e.ShipperName)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DimShipper> entity);
    }
}
