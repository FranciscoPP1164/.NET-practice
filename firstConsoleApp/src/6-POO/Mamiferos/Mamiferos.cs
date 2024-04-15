namespace POO.Mamiferos
{
    class Mamiferos(string nombre, byte edad)
    {
        private string nombre = nombre;
        private byte edad = edad;

        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Soy capaz de cuidar de mis crias");
        }

        public string Getnombre()
        {
            return nombre;
        }

        public void Setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        public byte GetEdad()
        {
            return edad;
        }

        public void SetEdad(byte edad)
        {
            this.edad = edad;
        }
    }
}
