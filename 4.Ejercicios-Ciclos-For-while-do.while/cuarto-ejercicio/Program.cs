using System;
using System.IO;

namespace cuarto_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio
            //si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente 
            //por 1 y por sí mismo.

            int n, con = 0;

            Console.WriteLine("Ingrese un nro: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++){
               if(n % i == 0)
                    con++;
            }
            if(con == 0)
                Console.WriteLine("Es primo");
            else 
                Console.WriteLine("no es primo");
        }
    
    }
} 
