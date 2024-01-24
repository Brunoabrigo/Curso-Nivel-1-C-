using System;

namespace Primer_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar 10 números. 
            //El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            //variables
            int n, con, conPrimos = 0;
            

            //ciclo para poder ingresar 10 numeros
            for (int i = 0; i < 10; i++)
            {
               n = int.Parse(Console.ReadLine());
                
                //se pone el contador adentro para que cada vez que se 
                //pida un numero este este en 0 y asi no cuenta los divisores del numero anterior
                con = 0;
                
                // se inicia el ciclo en 1 y da n cantidad de vueltas
                for (int x = 1; x <= n; x++)
                {
                    //operacion para saber si es primo usando la variable x inicializada en 1.
                    if (n % x == 0)
                    //se cuentan los numeros primos.
                       con++;
                    
                } 
                 //se hace una igualacion para saber si los numeros primos son divisibles 
                 //solo dos veces y si lo son, son primos
                 if (con == 2)
                    conPrimos++;
            }


           Console.WriteLine("La cantidad de numeros primos es: " + conPrimos);

  }
 }
} 

  
