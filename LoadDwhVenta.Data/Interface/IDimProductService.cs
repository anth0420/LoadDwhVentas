using LoadDwhVenta.Data.Core;

using LoadDwhVenta.Data.Entities.DwVentas;

namespace LoadDwhVenta.Data.Interface
{
    public interface IDimProductService
    {
        Task<OperationResult> LoadProduct(DimProduct product);
    }
}
