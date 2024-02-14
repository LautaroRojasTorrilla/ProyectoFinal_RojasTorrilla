using System.Text;

namespace Preentrega_ProyectoFinal.SistemaGestionEntities
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contraseña;
        private string _mail;

        public Usuario(int id, string nombre, string apellido,
            string nombreUsuario, string contraseña, string mail)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contraseña = contraseña;
            this._mail = mail;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }

        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Usuario: {this.NombreUsuario} \n");
            sb.AppendLine($"Email: {this.Mail} \n");
            return sb.ToString();
        }
    }
}
