
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LoadDwhVenta.Data.Entities.DwVentas.Configurations
{
    public partial class DimCustomerConfiguration : IEntityTypeConfiguration<DimCustomer>
    {
        public void Configure(EntityTypeBuilder<DimCustomer> entity)
        {
            entity.HasKey(e => e.CustomerKey).HasName("PK__DimCusto__95011E6485861FFB");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DimCustomer> entity);
    }
}
