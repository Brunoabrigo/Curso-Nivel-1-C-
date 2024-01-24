using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            //Luego hacer un programa que pida el precio de un artículo y 
            //la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
            
            
            int precio, cantVendida, montoTotal;

            Console.WriteLine("ingrese el precio del producto: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad vendida: ");
            cantVendida = int.Parse(Console.ReadLine());

            montoTotal = producto(precio, cantVendida);

            Console.WriteLine("El total a pagar es: " + montoTotal);


        }
    
        static int producto(int n1, int n2){
            int r;
            r = n1 * n2;
            return r;
        }
    
    
    
    }

}
