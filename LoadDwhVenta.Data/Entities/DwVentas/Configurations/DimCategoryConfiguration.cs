
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoadDwhVenta.Data.Entities.DwVentas.Configurations
{
    public partial class DimCategoryConfiguration : IEntityTypeConfiguration<DimCategory>
    {
        public void Configure(EntityTypeBuilder<DimCategory> entity)
        {
            entity.HasKey(e => e.CategoryKey);

            entity.ToTable("DimCategory");

            entity.Property(e => e.CategoryKey).ValueGeneratedNever();
            entity.Property(e => e.CategoryName).HasMaxLength(100);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DimCategory> entity);
    }
}
