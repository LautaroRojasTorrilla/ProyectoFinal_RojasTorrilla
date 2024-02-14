using Preentrega_ProyectoFinal.Service;
using Preentrega_ProyectoFinal.SistemaGestionData;

namespace Preentrega_ProyectoFinal.SistemaGestionBusiness
{
    public static class UsuarioBusiness
    {
        public static List<Usuario> GetAllUsers()
        {
            try
            {
                return UsuarioService.ObtenerTodosLosUsuarios();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener todos los usuarios desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static Usuario GetUserById(int id)
        {
            try
            {
                return UsuarioService.ObtenerUsuarioporID(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el usuario por ID desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static bool AddUser(Usuario user)
        {
            try
            {
                return UsuarioService.AgregarUsuario(user);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar el usuario desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static bool UpdateUserById(Usuario user, int id)
        {
            try
            {
                return UsuarioService.ModificarUsuarioPorId(user, id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el usuario desde la capa de negocio: {ex.Message}", ex);
            }
        }

        public static bool DeleteUserById(int id)
        {
            try
            {
                return UsuarioService.EliminarUsuarioPorID(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el usuario desde la capa de negocio: {ex.Message}", ex);
            }
        }
    }
}
