using LoadDwhVenta.Data.Core;

using LoadDwhVenta.Data.Entities.DwVentas;

namespace LoadDwhVenta.Data.Interface
{
    public interface IDimCategoryService
    {
        Task<OperationResult> LoadCategory(DimCategory category);
    }
}
