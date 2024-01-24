using System;

namespace primer_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultado;

            Console.WriteLine("Ingresa el primer número: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número: ");
            b = int.Parse(Console.ReadLine());

            if(a == b)
                resultado = a + b;
            
            else if(a > b)
                resultado = a - b;
                
            else
                resultado = a * b;
            
            Console.WriteLine("El resultado correspondiente es: " + resultado);

            }

        }
    }

