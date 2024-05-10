namespace POO.Mamiferos
{
    class Lagartija(string nombre, byte edad) : Animal
    {
        private string nombre = nombre;
        private byte edad = edad;

        public override string Getnombre()
        {
            return nombre;
        }

    }
}
