using System;

namespace Tercer_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
           //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
           //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            
           int num, conLista = 0, conNum = 0 ;
           
            Console.WriteLine("Ingrese nros: ");
            num = int.Parse(Console.ReadLine());
           
            while (num > 0)
            {
                conLista++;
                
                while (num != 0)
                {
                     conNum++;
                     Console.WriteLine("Ingrese nros: ");
                     num = int.Parse(Console.ReadLine());

                }
                    Console.WriteLine("La cantidad de numeros es: " + conNum);
                    Console.WriteLine("Ingrese nros: ");
                    num = int.Parse(Console.ReadLine());
                    conNum = 0;
                    
            }
            Console.WriteLine("La cantidad de numeros que tiene cada lista es: " +  conLista);
        }
    }
}
