using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios de Consola en clase...");
            // DibujaTriangulo();
            // QuitaLetra();  // Ejercicio 15
            XtremosCadena(); // Ejercicio 16
      
        }

        private static void QuitaLetra()
        {
            string cadena,posicion;
            Console.Write("Ingrese una cadena: ");
            cadena = Console.ReadLine();
            int largo = cadena.Length;
            int cpos = 0;
            Boolean seguir = true;
            do
            {
                Console.Write("Posición de caracter a borrar (1:primero): ");
                posicion = Console.ReadLine();
                cpos = int.Parse(posicion)-1;
                if (cpos <= (largo-1)&cpos>=0)
                {
                    seguir = false;
                }
            } while (seguir);
            if (cpos==0)
            {
                cadena = cadena.Substring(cpos + 1);
            }
            else
            {
                if (cpos==(largo-1))
                {
                    cadena = cadena.Substring(0, largo-1);
                }
                else
                {
                    cadena = cadena.Substring(0, cpos) + cadena.Substring(cpos+1);
                }
            }

           
            
            Console.WriteLine(cadena);
        }
        private static void XtremosCadena()
        {
            string cadena;
            Console.Write("Ingrese una cadena: ");
            cadena = Console.ReadLine();
            int largo = cadena.Length;
            cadena = cadena.Substring(largo - 1) + cadena.Substring(1, largo - 2) + cadena.Substring(0, 1);
            Console.WriteLine(cadena);

        }
        private static void DibujaTriangulo()
        {
            int menor;
            // declaración inicializando los contenidos conocidos
            // int[] sueldos = { 300, 190, 120, 99, 200 };

            // declaración sin conocerlos elementos iniciales
            int fil = 5;
            int col = 5;
            int f = 0;
            int c = 20;
            string s;
            s = c.ToString();
            Console.WriteLine("String: ***" + s + "***. Entero: ***" + c + "***");


            int[,] triangulo;
            triangulo = new int[fil, col];

            // ejemplo de asignación de valor
            //triangulo[f,c] = f;

            //  inicializar los valores - bucle

            // cargar el triangulo según sea izquierda, centro o derecha

            // dibujar el triangulo en la consola

            // redimensiono el array; solo se usa para UNIDIMENSIONALES - no en matrices
            // Array.Resize(ref arreglo, 7);

            //_ = Console.ReadKey();
        }
    }
}
