
using LoadDwhVenta.Data.Contexts.DwVentas;
using LoadDwhVenta.Data.Core;
using LoadDwhVenta.Data.Entities.DwVentas;
using LoadDwhVenta.Data.Interface;

namespace LoadDwhVenta.Data.Services
{
    public class DimCategoryService : IDimCategoryService
    {
        private readonly DwhVentasContext context;

        private  DimCategoryService(DwhVentasContext context)
        {
            this.context = context;
        }
        public async Task<OperationResult> LoadCategory(DimCategory category)
        {
            OperationResult operation = new OperationResult();
            try
            {
              

            }
            catch (Exception) 
            {
                operation.Success = false;
                operation.Message = $"Error cargando dimension de category";
            }
            return operation;
        }
    }
}
