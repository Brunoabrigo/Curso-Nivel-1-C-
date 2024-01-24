using System;

namespace quinto_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0, min = 0;
            int conPar = 0, conImpar = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0){
                    conPar ++;
                    if(conPar == 1)
                        max = n;
                    else if(n > max)
                        max = n;
                }else{  
                    conImpar++; 
                if(conImpar == 1)
                    min = n;
                else if(n < min)
                    min = n;
                    
                
                }
             } 

                Console.WriteLine("El maximo par es: " + max);
                Console.WriteLine("El minimo impar es: " + min);
            
            
        }
    }
}
