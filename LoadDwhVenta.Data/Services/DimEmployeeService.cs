

using LoadDwhVenta.Data.Contexts.DwVentas;
using LoadDwhVenta.Data.Core;
using LoadDwhVenta.Data.Entities.DwVentas;
using LoadDwhVenta.Data.Interface;

namespace LoadDwhVenta.Data.Services
{
    public class DimEmployeeService : iDimEmployeeService
    {
        private readonly DwhVentasContext context;

        public DimEmployeeService(DwhVentasContext context)
        {
            this.context = context;
        }
        public async Task<OperationResult> LoadEmployee(DimEmployee employee)
        {
            OperationResult operation = new OperationResult();
            try
            {


            }
            catch (Exception)
            {
                operation.Success = false;
                operation.Message = $"Error cargando dimension de employee";
            }
            return operation;
        }
    }
}
