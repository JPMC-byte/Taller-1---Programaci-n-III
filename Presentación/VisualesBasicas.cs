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
        Logica.EjerciciosBasicos Logica = new EjerciciosBasicos();
        public void ListaOrdenada()
        {
            List<int> List = new List<int>();
            char Opt;
            int Num, X = 3;

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
                }else {
                    if (Opt == 'N')
                    {
                        Console.SetCursorPosition(12, 17); Console.Write("                    ");
                    }
                    List.Add(Num);
                }
                Console.SetCursorPosition(35, 15); Console.Write("      ");
                Console.SetCursorPosition(32, 7); Console.Write("      ");

            } while (Opt == 'S' || Opt != 'N');


            Console.SetCursorPosition(5, 9); Console.WriteLine("Lista de numeros digitada: ");

            for (int i = 0; i < List.Count; i++)
            {
                Console.SetCursorPosition(X, 11); Console.Write(List[i]);
                X += 2;
            }

            Console.SetCursorPosition(5, 13); Console.WriteLine(Logica.LogicaListaOrdenada(List));

            Console.ReadKey();

        }

        public void AutentificaciónUsuario()
        {
            String Name, Password;
            char Opt;

            Console.Clear();
            do
            {
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Sistema de autentificación --- ");
                Console.SetCursorPosition(5, 7); Console.Write("Ingrese un nombre de usuario: ");
                Name = Console.ReadLine();
                Console.SetCursorPosition(5, 8); Console.Write("Ingrese una contraseña: ");
                Password = Console.ReadLine();

                Console.SetCursorPosition(10, 15); Console.Write("¿Esta seguro? (S/N): ");
                Opt = char.ToUpper(char.Parse(Console.ReadLine()));

                if (Opt != 'S' && Opt != 'N')
                {
                    Console.SetCursorPosition(12, 17); Console.WriteLine("Digito invalido");
                }
                else
                {
                    if (Opt == 'S')
                    {
                        Console.SetCursorPosition(12, 17); Console.Write("                    ");
                        break;
                    }
                }
                Console.SetCursorPosition(31, 15); Console.Write("      ");
                Console.SetCursorPosition(32, 7); Console.Write("              ");
                Console.SetCursorPosition(29, 8); Console.Write("              ");

            } while(Opt == 'N' && Opt != 'S');

            Console.SetCursorPosition(5, 13); Console.WriteLine(Logica.LogicaAutentificacionUsuario(Name,Password));
            Console.ReadKey();
        }
    }


}
