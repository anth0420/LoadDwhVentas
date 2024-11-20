using LoadDwhVenta.Data.Core;
using LoadDwhVenta.Data.Entities.DwVentas;
namespace LoadDwhVenta.Data.Interface
{
    public interface iDimEmployeeService
    {
        Task<OperationResult> LoadEmployee(DimEmployee employee);
    }
}
