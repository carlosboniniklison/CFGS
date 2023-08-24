using System;

namespace PrimerosPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            //SUMAREMOS  dos números
            int numero1;
            int numero2;
            int suma;
            long producto;
            float cociente;
            string linea;
            Console.Write("Ingrese el primer nro.: ");
            linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            Console.Write("Ingrese el segundo nro.: ");
            linea = Console.ReadLine();
            numero2 = int.Parse(linea);
            suma = numero1 + numero2;
            producto = numero1 * numero2;

            // el operador % es para calcular el resto
            cociente = numero1 / numero2;
            Console.Write("La suma es: ");
            Console.WriteLine(suma);
            if (suma<1000)
            {
                // bloque positivo
                Console.Write("El producto es: ");
                Console.WriteLine(producto);
            }
            else
            {
                // bloque negativo
                Console.Write("El cociente es: ");
                Console.WriteLine(cociente);
            }
           // para finalizar sin perder la consola
            Console.Write("Presione una tecla para continuar... ");
            Console.ReadKey();
 
        }
    }
}
