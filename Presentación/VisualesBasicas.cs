using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Logica;

namespace Presentación
{
    internal class VisualesBasicas
    {
        EjerciciosBasicos Logica = new EjerciciosBasicos();
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
                    Console.SetCursorPosition(12, 17); Console.Write("                    ");
                    List.Add(Num);
                }
                Console.SetCursorPosition(35, 15); Console.Write("      ");
                Console.SetCursorPosition(32, 7); Console.Write("      ");

            } while (Opt != 'N');


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
                    Console.SetCursorPosition(12, 17); Console.Write("                    ");
                }
                Console.SetCursorPosition(31, 15); Console.Write("      ");
                Console.SetCursorPosition(34, 7); Console.Write("              ");
                Console.SetCursorPosition(29, 8); Console.Write("              ");

            } while(Opt != 'S');

            Console.SetCursorPosition(5, 13); Console.WriteLine(Logica.LogicaAutentificacionUsuario(Name,Password));
            Console.ReadKey();
        }

        public void RaizCuadrada()
        {
            double Num;
            char Opt;

            Console.Clear();
            do
            {
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Calcular raiz cuadrada (No librerias) --- ");
                Console.SetCursorPosition(5, 7); Console.Write("Ingrese numero a calcular: ");
                Num = double.Parse(Console.ReadLine());

                Console.SetCursorPosition(10, 15); Console.Write("¿Esta seguro? (S/N): ");
                Opt = char.ToUpper(char.Parse(Console.ReadLine()));

                if ((Opt != 'S' && Opt != 'N') || (Num <= 0))
                {
                    Console.SetCursorPosition(12, 17); Console.WriteLine("Digito invalido");
                }
                else
                {
                    Console.SetCursorPosition(12, 17); Console.Write("                    ");
                }
                Console.SetCursorPosition(30, 15); Console.Write("            ");
                Console.SetCursorPosition(31, 7); Console.Write("              ");
            } while (Opt != 'S' || Num <= 0);

            Console.SetCursorPosition(5, 13); Console.WriteLine($"La raiz cuadrada de { Num } es: {Logica.LogicaRaizCuadrada(Num)}");
            Console.ReadKey();

        }

        public void PiedraPapelTijeras()
        {
            char Opt;
            String[] Opciones = { "Piedra", "Papel", "Tijeras" };
            int Respuesta;

            Console.Clear();
            do
            {
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Piedra, papel o tijeras --- ");
                Console.SetCursorPosition(3, 7); Console.WriteLine("1. Piedra");
                Console.SetCursorPosition(3, 8); Console.WriteLine("2. Papel");
                Console.SetCursorPosition(3, 9); Console.WriteLine("3. Tijeras");
                Console.SetCursorPosition(5, 10); Console.Write("Elija su opción (Entre piedra, papel o tijeras): ");
                Respuesta = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(10, 13); Console.Write("¿Esta seguro? (S/N): ");
                Opt = char.ToUpper(char.Parse(Console.ReadLine()));

                if ((Opt != 'S' && Opt != 'N') || (Respuesta < 1 || Respuesta > 3))
                {
                    Console.SetCursorPosition(12, 17); Console.WriteLine("Digito invalido");
                }
                else
                {
                    Console.SetCursorPosition(12, 17); Console.Write("                    ");
                }
                Console.SetCursorPosition(30, 13); Console.Write("            ");
                Console.SetCursorPosition(53, 10); Console.Write("              ");
            } while ((Opt != 'S') || (Respuesta < 1 || Respuesta > 3));

            var (Resultado, OpcionMaquina) = Logica.LogicaPiedraPapelTijeras(Respuesta - 1);

            Console.SetCursorPosition(5, 15); Console.WriteLine("Opción seleccionada: " + Opciones[Respuesta - 1]);
            Console.SetCursorPosition(5, 16); Console.WriteLine("Opción seleccionada por la maquina: " + OpcionMaquina);
            Console.SetCursorPosition(5, 18); Console.WriteLine("Los resultados son: " + Resultado);
            Console.ReadKey();
        }

        public void Palindromo()
        {
            String Texto, Resultado;
            char Opt;

            Console.Clear();
            do
            {
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- ¿Palabra palindroma o no palindroma? --- ");
                Console.SetCursorPosition(5, 7); Console.Write("Escriba la palabra a procesar: ");
                Texto = Console.ReadLine();

                Console.SetCursorPosition(10, 15); Console.Write("¿Esta seguro? (S/N): ");
                Opt = char.ToUpper(char.Parse(Console.ReadLine()));

                if (Opt != 'S' && Opt != 'N') 
                {
                    Console.SetCursorPosition(12, 17); Console.WriteLine("Digito invalido");
                }
                else
                {
                    Console.SetCursorPosition(12, 17); Console.Write("                    ");
                }
                Console.SetCursorPosition(30, 15); Console.Write("            ");
                Console.SetCursorPosition(36, 7); Console.Write("                     ");
            } while (Opt != 'S') ;
            Resultado = Logica.LogicaPalindromo(Texto);
            Console.SetCursorPosition(5, 13); Console.WriteLine($"La palabra digitada: {Texto} " + Resultado);
            Console.ReadKey();
        }

        public void ListaNoDuplicada()
        {
            List<int> List = new List<int>();
            List<int> ListNoDuplicados = new List<int>();
            char Opt;
            int Num, X = 3;

            Console.Clear();

            do
            {
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Lista no duplicada --- ");
                Console.SetCursorPosition(5, 7); Console.Write("Ingrese numeros a la lista: ");
                Num = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(10, 16); Console.Write("¿Desea continuar? (S/N): ");
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
                Console.SetCursorPosition(35, 16); Console.Write("      ");
                Console.SetCursorPosition(32, 7); Console.Write("      ");

            } while (Opt != 'N');


            Console.SetCursorPosition(5, 9); Console.WriteLine("Lista de numeros digitada: ");

            for (int i = 0; i < List.Count; i++)
            {
                Console.SetCursorPosition(X, 11); Console.Write(List[i]);
                X += 3;
            }

            ListNoDuplicados = Logica.LogicaListaNoDuplicada(List);
            X = 3;

            Console.SetCursorPosition(5, 13); Console.WriteLine("Lista de numeros sin duplicados: ");

            for (int i = 0; i < ListNoDuplicados.Count; i++)
            {
                Console.SetCursorPosition(X, 15); Console.Write(ListNoDuplicados[i]);
                X += 3;
            }
            Console.ReadKey();
        }

        public void ListaDoble()
        {
            var (Lista1, Lista2, ListaNueva) = Logica.LogicaListaDoble();
            int X = 3;

            Console.Clear();

            Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Dos lista separadas combinadas en una lista --- ");

            Console.SetCursorPosition(5, 7); Console.WriteLine("Lista N°1 de numeros: ");

            for (int i = 0; i < Lista1.Count; i++)
            {
                Console.SetCursorPosition(X, 9); Console.Write(Lista1[i]);
                X += 3;
            }

            X = 3;

            Console.SetCursorPosition(5, 11); Console.WriteLine("Lista N°2 de numeros: ");

            for (int i = 0; i < Lista2.Count; i++)
            {
                Console.SetCursorPosition(X, 13); Console.Write(Lista2[i]);
                X += 3;
            }

            X = 3;
            Console.SetCursorPosition(5, 15); Console.WriteLine("Listas combinada: ");

            for (int i = 0; i < ListaNueva.Count; i++)
            {
                Console.SetCursorPosition(X, 17); Console.Write(ListaNueva[i]);
                X += 3;
            }

            Console.ReadKey();

        }
    }


}
