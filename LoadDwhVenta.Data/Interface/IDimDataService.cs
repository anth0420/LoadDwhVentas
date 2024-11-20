using LoadDwhVenta.Data.Core;

using LoadDwhVenta.Data.Entities.DwVentas;

namespace LoadDwhVenta.Data.Interface
{
    public interface IDimDataService
    {
        Task<OperationResult> LoadData(DimDate date);
    }
}
