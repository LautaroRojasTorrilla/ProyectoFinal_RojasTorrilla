using Preentrega_ProyectoFinal.Service;
using Preentrega_ProyectoFinal.SistemaGestionData;


namespace Preentrega_ProyectoFinal.SistemaGestionBusiness
{
    public static class ProductoBusiness
    {
        public static List<Producto> GetAllProducts()
        {
            try
            {
                return ProductoService.ObtenerTodosLosProductos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener todos los productos desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static Producto GetProductById(int id)
        {
            try
            {
                return ProductoService.ObtenerProductoPorID(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el producto por ID desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static bool AddProduct(Producto product)
        {
            try
            {
                return ProductoService.AgregarProducto(product);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar el producto desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static bool UpdateProductById(Producto product, int id)
        {
            try
            {
                return ProductoService.ModificarProductoPorId(product, id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el producto desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static bool DeleteProductById(int id)
        {
            try
            {
                return ProductoService.EliminarProductoPorID(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el producto desde la capa de negocio: {ex.Message}", ex);
            }
        }
    }
}
