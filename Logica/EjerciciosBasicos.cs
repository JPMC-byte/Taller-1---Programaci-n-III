using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EjerciciosBasicos
    {
        public String LogicaListaOrdenada(List<int> List)
        {
            bool Asc = true, Desc = true;
            for (int i = 0; i < List.Count - 1; i++)
            {
                if (List[i] > List[i + 1])
                {
                    Asc = false;
                }
                if (List[i] < List[i + 1])
                {
                    Desc = false;
                }
            }

            if (Asc)
            {
                return "La lista se encuentra ordenada ascendentemente";
            }
            else if (Desc)
            {
                return "La lista se encuentra ordenada descendentemente";
            }
            else
            {
                return "La lista no se encuentra ordenada";
            }

        }


    }
}
