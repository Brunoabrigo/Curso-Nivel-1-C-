﻿using System;

namespace newcalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Escriba un número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba otro número: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}