using System;

namespace kilometros
{
    class Program
    {
        static void Main(string[] args)
        {
           
            float km, vel, time;
            

            Console.WriteLine("Ingresar Kilometros existentes: ");
            km = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar velocidad promedio: ");
            vel = float.Parse(Console.ReadLine());

            time = km / vel;

            Console.WriteLine("El tiempo aproximado es de: " + time.ToString("0.00") + " horas.");







        }
    }
}
