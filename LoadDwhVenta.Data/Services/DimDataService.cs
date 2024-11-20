

using LoadDwhVenta.Data.Contexts.DwVentas;
using LoadDwhVenta.Data.Core;
using LoadDwhVenta.Data.Entities.DwVentas;
using LoadDwhVenta.Data.Interface;

namespace LoadDwhVenta.Data.Services
{
    public class DimDataService : IDimCustomerService
    {
        private readonly DwhVentasContext context;

        public DimDataService(DwhVentasContext context)
        {
            this.context = context;
        }
        public async Task<OperationResult> LoadCUstomer(DimCustomer customer)
        {
            OperationResult operation = new OperationResult();
            try
            {


            }
            catch (Exception)
            {
                operation.Success = false;
                operation.Message = $"Error cargando dimension de Data";
            }
            return operation;
        }
    }
}
