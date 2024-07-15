namespace DelegadosPredicadosLambdas
{
    //Un delegado es un objeto el cual esta en la capacidad de delegar una tarea a una funcion, y cambiar la funcion la cual es delegada
    //En esencia son CallBacks
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
