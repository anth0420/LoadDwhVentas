
using LoadDwhVenta.Data.Contexts.DwVentas;
using LoadDwhVenta.Data.Core;
using LoadDwhVenta.Data.Entities.DwVentas;
using LoadDwhVenta.Data.Interface;

namespace LoadDwhVenta.Data.Services
{
    public class DimProductService : IDimProductService
    {
        private readonly DwhVentasContext context;

        public DimProductService(DwhVentasContext context)
        {
            this.context = context;
        }
        public async Task<OperationResult> LoadProduct(DimProduct product)
        {
            OperationResult operation = new OperationResult();
            try
            {


            }
            catch (Exception)
            {
                operation.Success = false;
                operation.Message = $"Error cargando dimension de product";
            }
            return operation;
        }
    }
}
