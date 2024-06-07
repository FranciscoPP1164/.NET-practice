namespace POO.Mamiferos
{
    //Las clases abstractas son aquellas clases de las cuales no se puede instanciar ningun objeto y solo se puede heredar de ellas.
    abstract class Animal()
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        //Los metodos abstractos solo tienen la declaracion del metodo mas no la implementacion, todos los metodos que sean declarados como abstractos, deben tener su propia implementacion en las clases que hereden de esta clase.
        public abstract string Getnombre();
    }
}
