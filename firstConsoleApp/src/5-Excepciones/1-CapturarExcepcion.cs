namespace Excepciones
{
    class CapturarExcepcion
    {
        public CapturarExcepcion()
        {
            int numero;

            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException formarException)
            {
                Console.WriteLine(formarException.Message);
                numero = 0;
            }

            Console.WriteLine(numero);
        }
    }
}
