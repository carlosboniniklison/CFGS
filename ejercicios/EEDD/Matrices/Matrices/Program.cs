using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] matriz;
            matriz = new int[2, 4];
            // asignar un valor específico
            matriz[1, 3] = 7;
            string linea;
            // cargamos los valores por pantalla
            for (int j = 0; j < matriz.GetLength(0); j++) {
                // cargamos las 4 notas de cada alumno
                Console.WriteLine("notas del alumno: "+(j+1));
                for (int h=0; h<matriz.GetLength(1); h++)
                {
                    Console.Write("Nota " + (h + 1) + ": ");
                    linea=Console.ReadLine();
                    matriz[j, h] = int.Parse(linea);
                }
            }

        }
    }
}
