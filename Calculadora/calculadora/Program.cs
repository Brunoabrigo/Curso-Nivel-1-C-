﻿using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = (n1 * n2) + (50 / n1);

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
