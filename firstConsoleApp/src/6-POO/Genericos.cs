using POO.Mamiferos.Interfaces;

namespace POO
{
    //Las clases genericas son clases las cuales se les puede especificar n numero de tipos que van a manejar de manera dinamica y que son especificadas cuando se esta construyendo un objeto

    //Las clases generias pueden tener restricciones como que solo acepten tipos que hereden de una clase o que implementen una interfaz
    class Genericos<T> where T : IMamiferosTerrestres
    {
        public Genericos(uint size)
        {
            items = new T[size];
        }

        private T[] items;
    }
}
