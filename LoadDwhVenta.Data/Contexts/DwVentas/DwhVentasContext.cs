using LoadDwhVenta.Data.Contexts.Nortwind;
using LoadDwhVenta.Data.Entities.DwVentas;
using LoadDwhVenta.Data.Entities.DwVentas.Configurations;
using Microsoft.EntityFrameworkCore;


namespace LoadDwhVenta.Data.Contexts.DwVentas
{
    public partial class DwhVentasContext : DbContext
    {
        public DwhVentasContext()
        {
        }

        public DwhVentasContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        public DbSet<DimCategory> DimCategories { get; set; }

        public DbSet<DimCustomer> DimCustomers { get; set; }

        public DbSet<DimDate> DimDates { get; set; }

        public DbSet<DimEmployee> DimEmployees { get; set; }

        public DbSet<DimProduct> DimProducts { get; set; }

        public DbSet<DimShipper> DimShippers { get; set; }

        public DbSet<FactClientesAtendido> FactClientesAtendidos { get; set; }

        public DbSet<FactOrder> FactOrders { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DimCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DimCustomerConfiguration());
            modelBuilder.ApplyConfiguration(new DimDateConfiguration());
            modelBuilder.ApplyConfiguration(new DimEmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new DimProductConfiguration());
            modelBuilder.ApplyConfiguration(new DimShipperConfiguration());
            modelBuilder.ApplyConfiguration(new FactClientesAtendidoConfiguration());
            modelBuilder.ApplyConfiguration(new FactOrderConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
