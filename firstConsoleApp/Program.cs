using POO;
using POO.Mamiferos;
using POO.Mamiferos.Interfaces;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // POO1();
            // Arrays();
            // Herencia();
            // Interfaces();
            ClasesAbstractas();
        }

        static void POO1()
        {
            //Las variables que se inicializan con un objeto de un tipo deben ser declaras con ese tipo de
            Circulo miCirculo = new Circulo();
            double area = miCirculo.CalcularArea(5);
            Console.WriteLine(area);

            //El punto se usa para acceder al contenido de un objeto
            ConverorPesoColombianoDolar conversor = new ConverorPesoColombianoDolar();
            Console.WriteLine(conversor.Cast(12));

            //getters
            Coche miCoche = new(1200, 400, true, "Cuerina");
            Console.WriteLine(miCoche.GetRuedas());
            Console.WriteLine(miCoche.GetInfoCoche());

            Console.WriteLine(Coche.getNumeroDeObjetos());

            //clase anonima
            var miVariable = new { Nombre = "Juan", Edad = 19 };
        }

        static void Arrays()
        {
            //Los arrays se definen especificando el largo que este tendra.
            int[] matriz = new int[4];

            //Otra manera de definir arrays
            int[] otraMatriz = { 1, 2, 3, 4, 5 };

            //Otra manera de definir arrays
            int[] otraMatriz1 = [1, 2, 3, 4, 5];

            //array implicito
            var datos = new[] { "Juan", "Díaz", "Carlos" };

            //array de objetos
            ConverorPesoColombianoDolar[] conversores = new ConverorPesoColombianoDolar[4];

            //bucle for para recorrer arrays usando la propiedad length
            for (int i = 0; i < otraMatriz.Length; i++)
            {
                Console.WriteLine(i);
            }

            //bucle foreach para recorrer un array
            foreach (ConverorPesoColombianoDolar conversor in conversores)
            {
                Console.WriteLine(conversor);
            }

            //un codigo sin ningun tipo de sentido
            int[] newArray = FunctionArray([1, 2, 3, 4]);

            foreach (int number in newArray)
            {
                Console.WriteLine(number);
            }
        }

        //metodo sin ningun tipo de sentido
        static int[] FunctionArray(int[] array)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i] + 10;
            }

            return newArray;
        }

        static void Herencia()
        {
            //Todas las clases heredan de la clase Mamiferos
            Perro max = new Perro("Max", 5);
            Humano juan = new Humano("Juan", 22);
            Gorila copito = new Gorila("Copito", 4);

            //Por lo tanto todos los objetos de estas clases poseen los metodos que se declaran en la clase Mamiferos
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

            //Principio de sustitucion "es-un"
            //Una variable que es declarada con un tipo puede ser inicializada con un objeto que es de un tipo que hereda del tipo de la declaracion.
            Mamiferos animal = new Perro("Skout", 2);

            Humano humano = new Humano("Franck", 19);
            Mamiferos mamiferos = new Mamiferos("Carlos", 19);

            //Principio de sustitucion
            Mamiferos[] listaDeMamiferos = [max, juan, copito];

            //Principio de sustitucion "es-un"
            mamiferos = humano;
            Console.WriteLine(mamiferos.Getnombre());

            copito.Pensar();
        }

        static void Interfaces()
        {
            //La clase ballena declara el metodo Nadar()
            Ballena miBallena = new Ballena("Wally", 6);
            miBallena.Nadar();

            //Principio de sustitucion "es-un"
            Perro perrito = new Perro("Princesa", 2);
            IMamiferosTerrestres mamiferoTerrestre = perrito;

            Console.WriteLine(mamiferoTerrestre.NumeroPatas());

            //Restricciones
            //No se permiten propiedades
            //No se permiten constructores
            //No se permiten destructores
            //No se especifican modificadores de acceso
            //No se pueden anidar ningun tipo de estructura dentro de una interfaz
        }

        static void ClasesAbstractas()
        {

        }
    }
}
