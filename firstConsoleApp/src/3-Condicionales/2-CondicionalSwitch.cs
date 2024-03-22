namespace Condicionales
{
    class CondicionalSwitch
    {
        public CondicionalSwitch()
        {
            int numero = 5;

            switch (numero)
            {
                case 3:
                    Console.WriteLine("El numero es 3");
                    break;
                case 4:
                    Console.WriteLine("El numero es 4");
                    break;
                case 5:
                    Console.WriteLine("El numero es 5");
                    break;
                default:
                    Console.WriteLine("No se encontro el numero");
                    break;
            }
        }
    }
}
