namespace Excepciones
{
    class Finally
    {
        public Finally()
        {
            int numero;

            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException formarException)
            {
                Console.WriteLine("No ha ingresado un valor numerico valido");
                Console.WriteLine(formarException.Message);
                numero = 0;
            }
            catch (OverflowException OverflowException)
            {
                Console.WriteLine("Ha ingresado un valor numerico muy grande");
                Console.WriteLine(OverflowException.Message);
                numero = 0;
            }
            catch (Exception GenericException) when (GenericException.GetType() != typeof(FormatException))
            {
                Console.WriteLine("Algo ha salido mal");
                Console.WriteLine(GenericException.Message);
                numero = 0;
            }
            finally
            {
                Console.WriteLine("Bloque que siempre se ejecutara :P");
            }

            Console.WriteLine(numero);
        }
    }
}
