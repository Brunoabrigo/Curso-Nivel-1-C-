using System;

namespace Segundo_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
            //Se pide determinar e informar:

            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el
            //grupo
            
           //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            
            int n, conImpar = 0, conTotal = 0, numMenor = 0 , porImpares = 0, mayorPor = 0, vueltaImpar = 0, enOrden = 0;
            bool ordenado = true;

           
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese nro:" );
                n = int.Parse(Console.ReadLine());
                numMenor = n;

                 if (n % 2 != 0)
                    
                     conImpar++;
             
                while (n != 0)
                {
                    Console.WriteLine("Ingrese nro:" );
                    n = int.Parse(Console.ReadLine());
                    conTotal++;

                   if (n % 2 != 0)
                    
                     conImpar++;

                   if (numMenor >= n)
                   {
                     numMenor = n;
                   }
                   else
                    {
                       ordenado = false; 
                    }
                    
            }
                porImpares = conImpar * 100 / conTotal;
                
                if (porImpares > mayorPor){
                mayorPor = porImpares ;
                vueltaImpar= i+1;
                    }
            
                if (ordenado){
                    enOrden++;
                }
                
        } 
                 Console.WriteLine($"El grupo con mayor poncentaje de impares es el: {vueltaImpar} y la cantidad de grupos ordenados de mayor a menor es {enOrden}");
                
      }
    }
}
