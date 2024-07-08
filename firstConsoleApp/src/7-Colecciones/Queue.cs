namespace Colecciones
{
    class ColeccionQueue
    {
        public ColeccionQueue()
        {
            Queue<int> numeros = new Queue<int>();

            numeros.Enqueue(1);
            numeros.Enqueue(2);
            numeros.Enqueue(3);
            numeros.Enqueue(4);
            numeros.Enqueue(5);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            int dequeuedNumber = numeros.Dequeue();

            Console.WriteLine(dequeuedNumber);
        }
    }
}
