using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersistenciaBasica
    {
        public bool PersistenciaUsuario(String usuario, String contraseña)
        {
            List<(String usuario, String contraseña)> usuarios = new List<(String usuario, String contraseña)>
            {
                ("usuario1", "contraseña1"),
                ("usuario2", "contraseña2"),
                ("admin", "admin123")
            };

            return usuarios.Any(u => u.usuario == usuario && u.contraseña == contraseña);
        }

    }
}
