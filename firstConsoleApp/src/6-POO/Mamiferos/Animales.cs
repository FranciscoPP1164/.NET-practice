namespace POO.Mamiferos
{
    abstract class Animal()
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract string Getnombre();
    }
}
