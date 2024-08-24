using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Presentación
{
    internal class VisualesIntermedias
    {
        EjerciciosIntermedios Logica = new EjerciciosIntermedios();
        public void PermutacionesPosibles()
        {
            List<int> List = new List<int>();
            char Opt;
            int Num, X = 50, Y = 5, FilasMaximas = 50;

            Console.Clear();

            do
            {
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Permutaciones posibles --- ");
                Console.SetCursorPosition(5, 7); Console.Write("Ingrese numeros a la lista: ");
                Num = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(10, 15); Console.Write("¿Desea continuar? (S/N): ");
                Opt = char.ToUpper(char.Parse(Console.ReadLine()));

                if (Opt != 'S' && Opt != 'N')
                {
                    Console.SetCursorPosition(12, 17); Console.WriteLine("Digito invalido");
                }
                else
                {
                    Console.SetCursorPosition(12, 17); Console.Write("                    ");
                    List.Add(Num);
                }
                Console.SetCursorPosition(35, 15); Console.Write("      ");
                Console.SetCursorPosition(32, 7); Console.Write("      ");

            } while (Opt != 'N');

            List<List<int>> Permutaciones = Logica.LogicaPermutacionesPosibles(List);

            Console.SetCursorPosition(50, 3); Console.WriteLine("Todas las permutaciones posibles:");
            foreach (var C in Permutaciones)
            {
                Console.SetCursorPosition(X,Y); Console.WriteLine( "( " + string.Join(", ", C) + " )");
                Y++;

                if (Y >= FilasMaximas)
                {
                    X += 20; // Moverse a la derecha 20 caracteres
                    Y = 5; // Reiniciar a la posición superior
                }
            }

            Console.ReadKey();
        }
    }
}
