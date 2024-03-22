namespace Bucles
{
    class While
    {
        public While()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            Console.WriteLine(randomNumber);

            Console.WriteLine("Por favor intenta adivinar el numero aleatorio");
            int numero = int.Parse(Console.ReadLine());

            while (numero != randomNumber)
            {
                Console.WriteLine("Se ha equivocado, intentalo nuevamente");
                Console.WriteLine("Por favor intenta adivinar el numero aleatorio");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Haz adivinado el numero");
        }
    }
}
