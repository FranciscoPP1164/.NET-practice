namespace Metodos
{
    class CrearMetodos
    {
        public CrearMetodos()
        {
            MensajeEnPantalla();
            SumaNumeros(4, 5);
            DivideNumeros(18, 7);
        }

        public void MensajeEnPantalla()
        {
            Console.WriteLine("Hola desde el método mensajeEnPantalla");
        }

        public int SumaNumeros(int num1, int num2)
        {
            return num1 + num2;
        }

        public double DivideNumeros(double num1, double num2) => num1 / num2;

    }
}
