
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoadDwhVenta.Data.Entities.DwVentas.Configurations
{
    public partial class DimDateConfiguration : IEntityTypeConfiguration<DimDate>
    {
        public void Configure(EntityTypeBuilder<DimDate> entity)
        {
            entity.HasKey(e => e.DateKey).HasName("PK__DimDate__40DF45E3045E0EE9");

            entity.ToTable("DimDate");

            entity.Property(e => e.DateKey).ValueGeneratedNever();
            entity.Property(e => e.DateName).HasMaxLength(50);
            entity.Property(e => e.MonthName).HasMaxLength(50);
            entity.Property(e => e.YearName).HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DimDate> entity);
    }
}
