namespace Condicionales
{
    class CondicionalIF
    {
        public CondicionalIF()
        {
            int edad = 15;
            String carnet = Console.ReadLine();

            if (edad >= 18 && carnet == "si")
            {
                Console.WriteLine("Bienvenido, puedes conducir un auto");
            }
            else
            {
                Console.WriteLine("No puedes conducir un auto");
            }
        }
    }
}
