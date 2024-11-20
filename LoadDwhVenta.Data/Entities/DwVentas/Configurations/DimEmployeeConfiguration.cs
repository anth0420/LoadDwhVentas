
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LoadDwhVenta.Data.Entities.DwVentas.Configurations
{
    public partial class DimEmployeeConfiguration : IEntityTypeConfiguration<DimEmployee>
    {
        public void Configure(EntityTypeBuilder<DimEmployee> entity)
        {
            entity.HasKey(e => e.EmployeeKey).HasName("PK__DimEmplo__8749E50A368F0127");

            entity.ToTable("DimEmployee");

            entity.Property(e => e.EmployeeName)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DimEmployee> entity);
    }
}
