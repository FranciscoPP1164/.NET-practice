namespace POO.Mamiferos
{
    //las clases sealed son aquellas clases de las cuales no se va a poder heredar desde ninguna clase

    sealed class Lagartija(string nombre, byte edad) : Animal
    {
        private string nombre = nombre;
        private byte edad = edad;

        //los metodos sealed son aquellos metodos que no son heredados por una subclase de la clase actual.
        sealed public override string Getnombre()
        {
            return nombre;
        }

    }
}
