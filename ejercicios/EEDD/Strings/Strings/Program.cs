using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string cadena;
            Console.Write("Ingrese un texto cualquiera: ");
            cadena = Console.ReadLine();
            Console.WriteLine("cadena: " + cadena);
            Console.WriteLine("MAYÚSCULAS: "+cadena.ToUpper());
            Console.WriteLine("minúsculas: " + cadena.ToLower());
            string letrainicial;
            string restocadena;
            letrainicial = cadena.Substring(0, 1).ToUpper();
            restocadena = cadena.Substring(1, cadena.Length - 1).ToLower();
            Console.WriteLine("Modo Frase: " + letrainicial + restocadena);
            int resultado = String.Compare(cadena.ToUpper(), cadena.ToLower());
            Console.WriteLine("MAYÚSCULAS vs minúsculas resulta en: "+ resultado);
            resultado = String.Compare(cadena.ToUpper(), cadena.ToUpper());
            Console.WriteLine("MAYÚSCULAS vs MAYÚSCULAS resulta en: "+ resultado);
            resultado = String.Compare(cadena.ToLower(), cadena.ToUpper());
            Console.WriteLine("minúsculas vs MAYÚSCULAS resulta en: "+ resultado);
            _ = Console.ReadKey();
        }
    }
}
