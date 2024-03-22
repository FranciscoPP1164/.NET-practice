namespace Metodos
{
    class ParametrosOpcionales
    {
        public ParametrosOpcionales()
        {
            SayHello();
            SayHello("Francisco");
        }

        public void SayHello(String nombre = "Mi nombre")
        {
            Console.WriteLine($"Hola {nombre}");
        }
    }
}
