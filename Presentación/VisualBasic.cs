using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentación
{
    internal class VisualBasic
    {
        public void SortedList()
        {
            Console.Clear();
            List<int> List = new List<int>();
            char Opt = 'S';
            int Num;
            bool Asc = true, Desc = true;

            do {
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Lista Ordenada --- ");
                Console.SetCursorPosition(5, 7); Console.Write("Ingrese numeros a la lista: ");
                Num = Console.Read();
                List.Add(Num);
                Console.SetCursorPosition(10, 15); Console.WriteLine("¿Desea continuar? (S/N)");
                Opt = Convert.ToChar(Console.ReadLine());
                char.ToUpper(Opt);
            } while ( Opt == 'S' );

            Console.SetCursorPosition(5, 9); Console.WriteLine("Lista de numeros digitada: ");

            foreach (int i in List)
            {
                Console.SetCursorPosition(3, 11); Console.Write(i); Console.Write(' ');

                if (List[i] > List[i + 1])
                {
                    Asc = false;
                }
                if (List[i] < List[i + 1])
                {
                    Desc = false;
                }
            }

            if (!Asc)
            {
                Console.WriteLine("La lista se encuentra ordenada ascendentemente");
            } else if (Desc) {
                Console.WriteLine("La lista se encuentra ordenada descendentemente");
            } else 
            {
                Console.WriteLine("La lista no se encuentra ordenada");
            }


        }
    }
}
