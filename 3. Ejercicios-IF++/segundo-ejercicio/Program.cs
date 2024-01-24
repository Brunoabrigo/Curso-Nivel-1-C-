using System;

namespace segundo_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
           float impVenta, ltsVendidos;

           Console.WriteLine("Ingrese importe de la venta: ");
           impVenta = float.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese cantidad de litros: ");
           ltsVendidos = float.Parse(Console.ReadLine());

           if(ltsVendidos > 500)
                impVenta *= 0.75F;
            
            else if (ltsVendidos > 300)
                impVenta *= 0.85F;
            
            else if (ltsVendidos > 100)
                impVenta *= 0.90F;
                
           
            Console.WriteLine("El importe final con descuento es: " + impVenta.toString(0.00));
         }     
                
     }
}
