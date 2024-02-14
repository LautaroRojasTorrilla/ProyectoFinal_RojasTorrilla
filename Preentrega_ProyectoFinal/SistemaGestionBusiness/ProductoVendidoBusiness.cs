using Preentrega_ProyectoFinal.Service;
using Preentrega_ProyectoFinal.SistemaGestionData;

namespace Preentrega_ProyectoFinal.SistemaGestionBusiness
{
    public static class ProductoVendidoBusiness
    {
        public static List<ProductoVendido> GetAllSoldProducts()
        {
            try
            {
                return ProductoVendidoService.ObtenerTodosLosProductosVendidos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener todos los productos vendidos desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static ProductoVendido GetSoldProductById(int id)
        {
            try
            {
                return ProductoVendidoService.ObtenerProductoVendidoPorID(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el producto vendido por ID desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static bool AddSoldProduct(ProductoVendido soldProduct)
        {
            try
            {
                return ProductoVendidoService.AgregarProductoVendido(soldProduct);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar el producto vendido desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static bool UpdateSoldProductById(ProductoVendido soldProduct, int id)
        {
            try
            {
                return ProductoVendidoService.ModificarProductoVendidoPorId(soldProduct, id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el producto vendido desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static bool DeleteSoldProductById(int id)
        {
            try
            {
                return ProductoVendidoService.EliminarProductoVendidoPorID(id);
            }
            catch (Exception ex)
            {
                // Puedes manejar el error de alguna manera específica de la capa de negocio si es necesario.
                throw new Exception($"Error al eliminar el producto vendido desde la capa de negocio: {ex.Message}", ex);
            }
        }

    }
}
