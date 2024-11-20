

using LoadDwhVenta.Data.Contexts.DwVentas;
using LoadDwhVenta.Data.Core;
using LoadDwhVenta.Data.Entities.DwVentas;
using LoadDwhVenta.Data.Interface;

namespace LoadDwhVenta.Data.Services
{
    public class DimShipperService : IDimShipperService
    {
        private readonly DwhVentasContext context;

        public DimShipperService(DwhVentasContext context)
        {
            this.context = context;
        }

        public async Task<OperationResult> LoadShipper(DimShipper shipper)
        {
            OperationResult operation = new OperationResult();
            try
            {


            }
            catch (Exception)
            {
                operation.Success = false;
                operation.Message = $"Error cargando dimension de shipper";
            }
            return operation;
        }
    }
}
