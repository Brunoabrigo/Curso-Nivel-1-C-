using System;

namespace promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, promedio;

            Console.WriteLine("Ingrese primer nota: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese sgunda nota: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tercer nota: ");
            n3 = float.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            Console.WriteLine("El promedio final es: " + promedio);


        }
    }
}
