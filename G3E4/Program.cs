using System;

namespace G3E4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PROGRAMACION ESTRUCTURADA GRUPO 07L 
             * 
             * OSCAR ROLANDO CAÑAS VALDIZON
             */

            //Se declaran las variables a utilizar
            double x1, x2, y1, y2, P;
            //Mensaje de bienvenida
            Console.WriteLine("Hola y bienvenidos. Este programa tiene la funcion de resolver la siguiente funcion:");
            Console.WriteLine("\n (x2 - x1)^2 + (y2 - y1)^2");
            //Solicitud del primer valor
            Console.WriteLine("\nPara iniciar por favor inserte el valor de x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            //Solicitud del segundo valor
            Console.WriteLine("Bien, ahora inserte el valor de y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            //Solicitud del tercer valor
            Console.WriteLine("Perfecto, ahora inserte el valor de x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            //Solicitud del cuarto valor
            Console.WriteLine("El ultimo paso, inserte el valor de y2:");
            y2 = Convert.ToDouble(Console.ReadLine());
            //Definicion de variable que soluciona la ecuacion
            P = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            //Impresion de resultado y cierre
            Console.WriteLine("El resultado de esta operacion es: " + P);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
