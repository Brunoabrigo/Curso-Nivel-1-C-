using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
          // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

           int n, conPar = 0;
           
              
           
            for (var i = 0; i < 20; i++)
            {
               Console.WriteLine("Ingresar nros: ");
               n = int.Parse(Console.ReadLine());
               if (par(n))
                conPar++;
            }
            Console.WriteLine("La cantidad de numeros pares es: " + conPar );
                
        }
        static bool par(int n1){
            if (n1 % 2 == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
