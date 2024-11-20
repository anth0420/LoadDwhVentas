
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LoadDwhVenta.Data.Entities.DwVentas.Configurations
{
    public partial class FactOrderConfiguration : IEntityTypeConfiguration<FactOrder>
    {
        public void Configure(EntityTypeBuilder<FactOrder> entity)
        {
            entity.HasKey(e => e.OrderNumber).HasName("PK__FactOrde__CAC5E742F4A7BA50");

            entity.Property(e => e.OrderNumber).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TotalVentas).HasColumnType("decimal(18, 2)");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FactOrder> entity);
    }
}
