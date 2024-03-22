using System;
using POO;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo = new Circulo();
            double area = miCirculo.CalcularArea(5);
            Console.WriteLine(area);

            ConverorPesoColombianoDolar conversor = new ConverorPesoColombianoDolar();
            Console.WriteLine(conversor.Cast(12));

            Coche miCoche = new(1200, 400, true, "Cuerina");
            Console.WriteLine(miCoche.GetRuedas());
            Console.WriteLine(miCoche.GetInfoCoche());
        }
    }
}
