using POO.Mamiferos.Interfaces;

namespace POO.Mamiferos
{
    class Perro(string nombre, byte edad) : Mamiferos(nombre, edad), IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public void Correr()
        {
            Console.WriteLine("Soy capaz de correr");
        }

        //Cuando una clase hereda de de dos interfaces las cuales tienen dos metodos con la misma firma, se debe ignorar el modificador
        //de accesos y especificar a cual interface hace referencia cada implementacion del metodo de cada interfaz.
        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }

        public string TipoDeporte()
        {
            return "Carrera de perros";
        }

        public bool EsOlimpico()
        {
            return true;
        }
    }
}
