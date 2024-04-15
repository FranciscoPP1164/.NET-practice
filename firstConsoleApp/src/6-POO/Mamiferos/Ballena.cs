namespace POO.Mamiferos
{
    class Ballena(string nombre, byte edad) : Mamiferos(nombre, edad)
    {
        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}
