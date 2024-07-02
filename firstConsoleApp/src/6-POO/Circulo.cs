namespace POO
{
    class Circulo
    {
        private const double pi = 3.1416;

        public double CalcularArea(int radio)
        {
            return Math.Pow(radio, 2) * pi;
        }

        //Los destructores son metodos que son invocados cuando el objeto es destruido por el garbage colector
        ~Circulo()
        {
            Console.WriteLine("Destruyendo el objeto");
        }
    }
}
