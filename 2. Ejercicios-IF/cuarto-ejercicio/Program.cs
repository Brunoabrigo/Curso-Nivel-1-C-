using System;

namespace cuarto_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            int menor;

            Console.WriteLine("ingresar primer número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresar segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresar tercer número: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresar cuarto número: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 < n2)
                menor = n1;
                else
                    menor = n2;
                    
                if(n3 < menor)
                    menor = n3;
                    
                if(n4 < menor)
                    menor = n4;
             
                
                Console.WriteLine("El menor es: " + menor);
        }
    }
 }
