namespace DelegadosPredicadosLambdas
{
    class Delegados
    {
        public Delegados()
        {
            ObjetoDelegado miDelegado = new ObjetoDelegado(Welcome.SayWelcome);
            miDelegado("Francisco");

            miDelegado = new ObjetoDelegado(Farewell.SayBay);
            miDelegado("Andres");
        }

        delegate void ObjetoDelegado(string message);
    }

    class Welcome
    {
        public static void SayWelcome(string message)
        {
            Console.WriteLine("Bienvenido " + message);
        }
    }

    class Farewell
    {
        public static void SayBay(string message)
        {
            Console.WriteLine("Adios " + message);
        }
    }
}
