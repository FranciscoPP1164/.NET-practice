namespace POO.Mamiferos
{
    //La clase mamifero se declara como clase de la cual heredan todas las clases que sean consideradas un mamifero
    class Mamiferos(string nombre, byte edad) : Animal
    {
        //propiedades / campos / atributos
        private string nombre = nombre;
        private byte edad = edad;

        //Las properties permiten acceder a una prop privada con una sintaxis como si esta fuera publica desde una clase exterior
        //Pero con las ventajas de la encapsulacion, ya que podemos previamente realizar una operacion antes de la lectura o asignacion.
        // public byte EDAD
        // {
        //     get { return edad; }
        //     set { edad = ValidarEdad(value); }
        // }

        //Se puede escribir una propertie con expresiones lambda
        public byte EDAD
        {
            get => edad;
            set => edad = ValidarEdad(value);
        }

        public byte ValidarEdad(byte edad)
        {
            if (edad < 0) return 0;
            return edad;
        }

        //La palabra reservada virtual del metodo Pensar() especifica que todas las clases hijas de la clase Mamiferos deben tener su propia implementacion del metodo Pensar()
        //Adaptando su comportamiento a la necesidad puntual de la clase
        //De esta forma cuando declaro un metodo Pensar() en una subclase de Mamiferos, lo que estaria haciendo es modificar el comportamiento del meotod Pensar() de la clase Mamiferos para esa clase puntual
        //No ocultandola como si fuera el caso de no usar la palabra reservada virtual
        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }

        //Metodos
        public void CuidarCrias()
        {
            Console.WriteLine("Soy capaz de cuidar de mis crias");
        }

        public override string Getnombre()
        {
            return nombre;
        }

        public void Setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        // public byte GetEdad()
        // {
        //     return edad;
        // }

        // public void SetEdad(byte edad)
        // {
        //     if (edad < 0)
        //     {
        //         this.edad = 0;
        //         return;
        //     }

        //     this.edad = edad;
        // }
    }
}
