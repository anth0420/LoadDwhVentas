
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LoadDwhVenta.Data.Entities.DwVentas.Configurations
{
    public partial class FactClientesAtendidoConfiguration : IEntityTypeConfiguration<FactClientesAtendido>
    {
        public void Configure(EntityTypeBuilder<FactClientesAtendido> entity)
        {
            entity.HasKey(e => e.ClienteAtendidoKey).HasName("PK__FactClie__B70C6B93F884893C");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<FactClientesAtendido> entity);
    }
}
