using POO;
using POO.Mamiferos;

namespace App
{
    class Program
    {


        static void Main(string[] args)
        {
            // POO1();
            // Arrays();
            // Erencia();
            Interfaces();
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

            int[] newArray = FunctionArray([1, 2, 3, 4]);

            foreach (int number in newArray)
            {
                Console.WriteLine(number);
            }
        }

        static int[] FunctionArray(int[] array)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i] + 10;
            }

            return newArray;
        }

        static void Erencia()
        {
            Perro max = new Perro("Max", 5);
            Humano juan = new Humano("Juan", 22);
            Gorila copito = new Gorila("Copito", 4);

            max.Correr();
            juan.Pensar();
            copito.Trepar();

            max.Respirar();
            juan.Respirar();
            copito.Respirar();

            max.CuidarCrias();
            juan.CuidarCrias();
            copito.CuidarCrias();

            Console.WriteLine(max.Getnombre());
            Console.WriteLine(juan.Getnombre());
            Console.WriteLine(copito.Getnombre());

            max.Setnombre("Princesa");
            juan.Setnombre("Sebastian");
            copito.Setnombre("Kerchan");

            Console.WriteLine(max.Getnombre());
            Console.WriteLine(juan.Getnombre());
            Console.WriteLine(copito.Getnombre());

            Mamiferos animal = new Perro("Skout", 2);

            Humano humano = new Humano("Franck", 19);
            Mamiferos mamiferos = new Mamiferos("Carlos", 19);

            mamiferos = humano;
            Console.WriteLine(mamiferos.Getnombre());

            copito.Pensar();
        }

        static void Interfaces()
        {
            Ballena miBallena = new Ballena("Wally", 6);
            miBallena.Nadar();

            Perro perrito = new Perro("Princesa", 2);
            Console.WriteLine(perrito.NumeroPatas());
        }
    }
}
