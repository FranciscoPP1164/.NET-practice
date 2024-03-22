namespace Excepciones
{
    class Checked
    {
        public Checked()
        {
            //la palabra reservada checked crea un bloque el cual sera revisado de manera estricta
            checked
            {
                int numero = int.MaxValue;

                //tambien se puede usar como una funcion
                //int resultado = checked(numero + 20);
                int resultado = numero + 20;
                Console.WriteLine(resultado);
            }

            //unchecked es lo contrario a checked, no revisa de manera estricta
            unchecked
            {
                int numero = int.MaxValue;
                int resultado = numero + 20;
                Console.WriteLine(resultado);
            }
        }
    }
}
