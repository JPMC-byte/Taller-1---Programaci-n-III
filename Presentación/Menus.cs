using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Presentación
{
    internal class Menus
    {
        public void MainMenu() {

            int Opt;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Menu principal --- ");
                Console.SetCursorPosition(5, 7); Console.WriteLine(" 1. Ejercicios basicos ");
                Console.SetCursorPosition(5, 8); Console.WriteLine(" 2. Ejercicios intermedios ");
                Console.SetCursorPosition(5, 9); Console.WriteLine(" 3. Ejercicios avanzados ");
                Console.SetCursorPosition(5, 10); Console.WriteLine(" 0. Salir ");
                Console.SetCursorPosition(5, 11); Console.Write("Seleccione su opción: ");
                Opt = int.Parse(Console.ReadLine());
         
                switch (Opt)
                {
                    case 1: MenuBasico(); break;
                    case 2: break;
                    case 3: break;
                    case 4: Opt = 0; break;
                }
            } while (Opt != 0);
        }

        public void MenuBasico()
        {
            
            int Opt;
            VisualesBasicas visualesBasicas = new VisualesBasicas();
            do
            {
                Console.Clear();
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Ejercicios basicos ---");
                Console.SetCursorPosition(5, 7); Console.WriteLine("1. Lista ordenada ");
                Console.SetCursorPosition(5, 8); Console.WriteLine("2. Autentificación de usuario ");
                Console.SetCursorPosition(5, 9); Console.WriteLine("3. Raiz cuadrada (No librerias)");
                Console.SetCursorPosition(5, 10); Console.WriteLine("4. Piedra, papel o tijera");
                Console.SetCursorPosition(5, 11); Console.WriteLine("5. Palabra palindromo");
                Console.SetCursorPosition(5, 12); Console.WriteLine("0. Volver al menu anterior");
                Console.Write("Seleccione su opción: ");
                Opt = int.Parse(Console.ReadLine());
                switch (Opt)
                {
                    case 1: visualesBasicas.ListaOrdenada(); break;
                    case 2: visualesBasicas.AutentificaciónUsuario(); break;
                    case 3: visualesBasicas.RaizCuadrada(); break;
                    case 4: visualesBasicas.PiedraPapelTijeras(); break;
                    case 5: visualesBasicas.Palindromo(); break;
                    case 0: Opt = 0; break;
                }
            } while (Opt != 0);
        }
    }
}
