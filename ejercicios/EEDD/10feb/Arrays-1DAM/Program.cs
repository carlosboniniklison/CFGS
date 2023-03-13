using System;

namespace Arrays_1DAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            string linea;
            linea = Console.ReadLine();
            Console.Write(linea);

            //lee 4 elementos
            for (int i = 0; i < 4; i++)
            {
                linea = Console.ReadLine();
                Console.Write(linea);
            }

            //lee hasta que la linea sea fin
            Boolean control = true;
            while (control)
            {
                linea = Console.ReadLine();
                Console.Write(linea);
                if (linea == "fin")
                {
                    control = false;
                }
            }

            do
            {
                linea = Console.ReadLine();
                Console.Write(linea);
                if (linea == "fin")
                {
                    control = false;
                }
                else
                {
                    control = true;
                }
            } while (true);
            Console.ReadKey();
        }
    }
}
