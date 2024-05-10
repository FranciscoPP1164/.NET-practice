using POO.Mamiferos.Interfaces;

namespace POO.Mamiferos
{
    class Humano(string nombre, byte edad) : Mamiferos(nombre, edad), IMamiferosTerrestres
    {
        //Si una clase declara un metodo con la misma firma de un metodo declarado en su clase padre, el metodo de la clase ocultara o invalidara el metodo de la clase padre.(Esto genera una advertencia)
        //Si se desea especificar que este es el comportamiento deseado utilizar la palabra new. ( new public void pensar() )
        //Si se desea sobreescribir el comportamiento del metodo de la clase padre, siendo esta virtual en la clase padre, se bede usar la palabra reservada override.

        //sobreescritura del metodo Pensar() de la clase Mamiferos
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
