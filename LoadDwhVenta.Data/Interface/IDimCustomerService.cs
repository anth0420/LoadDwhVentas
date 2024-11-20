using LoadDwhVenta.Data.Core;

using LoadDwhVenta.Data.Entities.DwVentas;

namespace LoadDwhVenta.Data.Interface
{
    public interface IDimCustomerService
    {
        Task<OperationResult> LoadCUstomer(DimCustomer customer);
    }
}
