using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersistenciaUsuario
    {
        private List<(String usuario, String contraseña)> usuarios;

        public PersistenciaUsuario()
        {
            usuarios = new List<(String usuario, String contraseña)>
            {
                ("usuario1", "contraseña1"),
                ("usuario2", "contraseña2"),
                ("admin", "admin123")
            };
        }
        public bool VerificarCredenciales(String usuario, String contraseña)
        {
            return usuarios.Any(u => u.usuario == usuario && u.contraseña == contraseña);
        }
    }
}
