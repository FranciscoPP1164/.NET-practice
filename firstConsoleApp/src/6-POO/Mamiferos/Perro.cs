using POO.Mamiferos.Interfaces;

namespace POO.Mamiferos
{
    class Perro(string nombre, byte edad) : Mamiferos(nombre, edad), IMamiferosTerrestres
    {
        public void Correr()
        {
            Console.WriteLine("Soy capaz de correr");
        }

        public int NumeroPatas()
        {
            return 4;
        }
    }
}
