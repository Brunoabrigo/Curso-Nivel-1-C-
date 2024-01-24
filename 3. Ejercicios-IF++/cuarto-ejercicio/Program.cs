using System;

namespace cuarto_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, resultado1, resultado2;

            Console.WriteLine("ingresa el primer número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresa el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresa el tercer número: ");
            n3 = int.Parse(Console.ReadLine());

            resultado1 = n1 + n2;

            resultado2 = n2 * n3;

            if(resultado1 > resultado2)
                Console.WriteLine("Es mayor");
            
            
        }
    }
}
