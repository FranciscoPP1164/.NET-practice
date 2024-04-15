namespace POO.Mamiferos
{
    class Gorila(string nombre, byte edad) : Mamiferos(nombre, edad)
    {
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public int NumeroPatas()
        {
            return 2;
        }
    }
}
