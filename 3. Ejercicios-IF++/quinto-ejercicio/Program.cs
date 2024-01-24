using System;

namespace quinto_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Ingresa el primer número: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer número: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el cuarto número: ");
            d = int.Parse(Console.ReadLine());

                if(a > b && b > c && c > d)
                     Console.WriteLine("Ordenados");
                    else
                     Console.WriteLine("Desordenados");
                    
        }
    }
}
