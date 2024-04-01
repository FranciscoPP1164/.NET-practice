using POO;

namespace App
{
    class Program
    {


        static void Main(string[] args)
        {
            // POO1();
            Arrays();
        }

        static void POO1()
        {
            Circulo miCirculo = new Circulo();
            double area = miCirculo.CalcularArea(5);
            Console.WriteLine(area);

            ConverorPesoColombianoDolar conversor = new ConverorPesoColombianoDolar();
            Console.WriteLine(conversor.Cast(12));

            Coche miCoche = new(1200, 400, true, "Cuerina");
            Console.WriteLine(miCoche.GetRuedas());
            Console.WriteLine(miCoche.GetInfoCoche());

            Console.WriteLine(Coche.getNumeroDeObjetos());

            var miVariable = new { Nombre = "Juan", Edad = 19 };
        }

        static void Arrays()
        {
            int[] matriz = new int[4];

            int[] otraMatriz = { 1, 2, 3, 4, 5 };

            int[] otraMatriz1 = [1, 2, 3, 4, 5];

            //array implicito
            var datos = new[] { "Juan", "Díaz", "Carlos" };

            //array de objetos
            ConverorPesoColombianoDolar[] conversores = new ConverorPesoColombianoDolar[4];

            for (int i = 0; i < otraMatriz.Length; i++)
            {
                Console.WriteLine(i);
            }

            foreach (ConverorPesoColombianoDolar conversor in conversores)
            {
                Console.WriteLine(conversor);
            }
        }
    }
}
