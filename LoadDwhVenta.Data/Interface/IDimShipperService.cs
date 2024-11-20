using LoadDwhVenta.Data.Core;
using LoadDwhVenta.Data.Entities.DwVentas;

namespace LoadDwhVenta.Data.Interface
{
    public interface IDimShipperService
    {
        Task<OperationResult> LoadShipper(DimShipper shipper);
    }
}
