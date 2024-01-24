using System;

namespace tercer_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
           float edad, acu = 0, con = 0, promedio;

           for (int i = 0; i < 20; i++)
         {
            Console.WriteLine("Ingrese Edad: ");
            edad = float.Parse(Console.ReadLine());

            if(edad > 18){
                acu += edad;
                con++;
            }

           }
            promedio = acu / con;
            Console.WriteLine("El promedio de edades es: " + promedio);
               
        }
    }
}
