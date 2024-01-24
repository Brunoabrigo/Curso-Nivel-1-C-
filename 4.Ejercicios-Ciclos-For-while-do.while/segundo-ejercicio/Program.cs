using System;

namespace segundo_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, mayor = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());

                if(i == 0)
                    mayor = n;
                else{
                    if (n > mayor)
                
                    mayor = n;
            }
                
      }
            Console.WriteLine("El mayor es: " + mayor);

            
        }
    }
}
