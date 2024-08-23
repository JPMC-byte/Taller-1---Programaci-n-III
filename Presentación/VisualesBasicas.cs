using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Presentación
{
    internal class VisualesBasicas
    {
        public void ListaOrdenada()
        {
            List<int> List = new List<int>();
            char Opt = 'S';
            int Num, X = 3;
            Logica.EjerciciosBasicos Logica = new EjerciciosBasicos();

            Console.Clear();

            do
            {
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Lista Ordenada --- ");
                Console.SetCursorPosition(5, 7); Console.Write("Ingrese numeros a la lista: ");
                Num = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(10, 15); Console.Write("¿Desea continuar? (S/N): ");
                Opt = char.ToUpper(char.Parse(Console.ReadLine()));

                if (Opt != 'S' && Opt != 'N')
                {
                    Console.SetCursorPosition(12, 17); Console.WriteLine("Digito invalido");
                    Console.SetCursorPosition(36, 15); Console.Write(' ');
                }
                if (Opt == 'N')
                {
                    Console.SetCursorPosition(12, 17); Console.Write("                    ");
                }
                List.Add(Num);
            } while (Opt == 'S' && Opt != 'N');


            Console.SetCursorPosition(5, 9); Console.WriteLine("Lista de numeros digitada: ");

            for (int i = 0; i < List.Count; i++)
            {
                Console.SetCursorPosition(X, 11); Console.Write(List[i]);
                X = X + 2;
            }

            Console.SetCursorPosition(5, 13); Console.WriteLine(Logica.LogicaListaOrdenada(List));

            Console.ReadKey();
            Console.Clear();

        }
    }
}
