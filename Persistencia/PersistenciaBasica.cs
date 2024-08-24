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

        public (List<int>, List<int>) PersistenciaListaDoble()
        {
            List<int> Lista1 = new List<int> { 0, 2, 4, 6, 8, 10, 12, 14, 16 };
            List<int> Lista2 = new List<int> { 1, 3, 5, 7, 9, 11 };

            return (Lista1, Lista2);
        }

    }
}
