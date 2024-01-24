using System;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y 
            //su posición dentro del vector.
            int n;
            int[] numeros = new int[10];
            
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese los nùmeros: ");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;

                int max = 0;
            if (n > max)
            {
                nuevoMax = n;
            }
            else
            {
                n = max;
            }


         }
            
            Console.WriteLine("El maximo es: " + max);
            


            




        }
    }
}
