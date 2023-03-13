using System;

namespace TrianguloBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura repetitiva FOR
            int i;
            for (i=1; i<=10;i++)
            {
                // instrucciones a repetir dentro del bucle
            }
            //
            //
            // Estructura repetitiva WHILE
            int j;
            j = 1;
            while (j<= 10)
            {
                // instrucciones a repetir dentro del bucle
                j = j + 1; //  j++;
            }
            //
            //
            // Estructura repetitiva DO.. WHILE para cuenta atrás
            int k;
            int h;
            k = 1;
            do
            {
                // instrucciones a repetir dentro del bucle
                for (h = 1; h < 10; h++)
                {
                    Console.Write(" ");
                }

                for (h=1;h<=(int)((9-k)/2);h++)
                {
                    Console.Write(" ");
                }
                for (h=1;h<k;h++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
                
                k++;
            } while (k != 10);
            //Console.ReadKey();
        }
    }
}
