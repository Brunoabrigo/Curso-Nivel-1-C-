using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o 
            //cero si no lo es. Hacer un programa para ingresar números. 
            //El lote corta cuando se ingresa un número cero. 
            //Informar el promedio teniendo en cuenta sólo los números primos.

            int num, conPrimos = 0, promedio = 0, acuPrimos = 0;

            Console.WriteLine("Ingresa nros: ");
            num = int.Parse(Console.ReadLine());


            while (num != 0)
            {
                Console.WriteLine("Ingresa nros: ");
                num = int.Parse(Console.ReadLine());

                if (primo(num))
                {
                    conPrimos++;
                    acuPrimos+=num;
                }
                Console.WriteLine("Ingresa otro: ");
                num = int.Parse(Console.ReadLine());

                
            }
             promedio = acuPrimos / conPrimos;

            Console.WriteLine("El promedio es: " + promedio);

        }

        static bool primo(int n){
            int con = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                
                    con++;
             }   
                if (con == 2)
                
                    return true;
                else
                
                    return false;
                
            
        }

        }
    }

