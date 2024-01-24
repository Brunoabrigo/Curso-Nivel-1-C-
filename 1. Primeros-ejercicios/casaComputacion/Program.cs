using System;

namespace casaComputacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            float totalF, sueldoT, sueldoC;
            const float sueldoFijo = 15000;
            const float porcentajeComision = 0.05F;

            Console.WriteLine("Ingresa el total facturado: ");
            totalF = float.Parse(Console.ReadLine());

             sueldoC = totalF * porcentajeComision;

            sueldoT = sueldoC + sueldoFijo;

            Console.WriteLine("Total a cobrar: " + sueldoT);                                                      
        }
    }
}
