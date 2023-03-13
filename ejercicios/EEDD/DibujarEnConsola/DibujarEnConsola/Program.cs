using System;
using System::Threading;

namespace DibujarEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ejercicios de Consola");
            Console.Write("Presione una tecla para pintar una columna de equis");
            _=Console.ReadKey();
            Pinta20();
            Console.Clear();
            Console.Write("... y ahora para pintar de abajo hacia arriba");
            _ = Console.ReadKey();
            PintaInverso();
        }

        static void PintaInverso(int mseg)
        {
            Console.Clear();
            for (int i = 20; i > 0; i--)
            {
                // ubico el cursor en la fila 20
                Console.SetCursorPosition(1, i);
                // imprimo un caracter luego de esperar mseg
                Thread::Sleep(mseg);
                Console.Write("X");
            }

            // muestro mensaje en la fila 20
            Console.SetCursorPosition(3, 20); 
            Console.Write("- Presione una tecla para terminar");
            _ = Console.ReadKey();
        }


        static void Pinta20()
        {
            Console.Clear();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("X");
            }
            Console.Write("X - Presione una tecla para terminar");
            _ = Console.ReadKey();
        }

    }
}
