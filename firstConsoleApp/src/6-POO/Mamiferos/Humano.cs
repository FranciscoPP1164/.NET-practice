using POO.Mamiferos.Interfaces;

namespace POO.Mamiferos
{
    class Humano(string nombre, byte edad) : Mamiferos(nombre, edad)
    {
        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }

        public int NumeroPatas()
        {
            return 2;
        }
    }
}
