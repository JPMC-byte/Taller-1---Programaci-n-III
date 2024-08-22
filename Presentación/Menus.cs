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
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Menu principal --- ");
                Console.SetCursorPosition(5, 7); Console.WriteLine(" 1. Ejercicios basicos ");
                Console.SetCursorPosition(5, 8); Console.WriteLine(" 2. Ejercicios intermedios ");
                Console.SetCursorPosition(5, 9); Console.WriteLine(" 3. Ejercicios avanzados ");
                Console.SetCursorPosition(5, 10); Console.WriteLine("0. Salir ");
                Opt = int.Parse(Console.ReadLine());
            } while (Opt != 0);

            switch (Opt)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: Opt = 0; break;
            }
        }

        public void MenuBasico()
        {
            Console.Clear();
            int Opt = 0;
            do
            {
                Console.SetCursorPosition(10, 5); Console.WriteLine(" --- Ejercicios basicos ---");
                Console.SetCursorPosition(5, 7); Console.WriteLine("1. Lista ordenada ");
                Console.SetCursorPosition(5, 8); Console.WriteLine("2. Autentificación de usuario ");
            } while (Opt != 0);
        }
    }
}
