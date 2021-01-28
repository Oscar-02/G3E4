using System;

namespace G3E4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, P;
            Console.WriteLine("Por favor inserte el valor de x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bien, ahora inserte el valor de x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Perfecto, ahora inserte el valor de y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El ultimo paso, inserte el valor de y2:");
            y2 = Convert.ToDouble(Console.ReadLine());
            P = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            Console.WriteLine("El resultado de esta operacion es: " + P);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
