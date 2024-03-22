namespace Bucles
{
    class DoWhile
    {
        public DoWhile()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            Console.WriteLine(randomNumber);

            int numero;

            do
            {
                Console.WriteLine("Por favor intenta adivinar el numero aleatorio");
                numero = int.Parse(Console.ReadLine());
            } while (numero != randomNumber);

            Console.WriteLine("Haz adivinado el numero");
        }
    }
}
