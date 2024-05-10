using POO.Mamiferos.Interfaces;

namespace POO.Mamiferos
{
    class Gorila(string nombre, byte edad) : Mamiferos(nombre, edad), IMamiferosTerrestres
    {
        //El metodo Pensar() de Gorila es independiente al metodo Pensar de Humano
        //Se debe considerar si el metodo Pensar() de las clases hijas no tiene nada que ver con el metodo Pensar() de Mamiferos
        //en este caso si tienen que ver, ya que, los humanos y gorilas si tienen un pensamiento basico instintivo, pero tambien tienen otro tipo de pensamientos mas complejos
        //Se puede decir que los metodos Pensar() de Gorila y Humano, no son ajenos al metodo Pensar() de Mamiferos, son una extension, una implementacion del mismo metodo, pero mas adaptada a la clase puntual

        //Ocultacion del metodo Pensar() de la clase Mamiferos
        new public void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }

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
