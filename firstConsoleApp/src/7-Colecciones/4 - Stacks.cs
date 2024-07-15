namespace Colecciones
{
    class ColeccionStack
    {
        public ColeccionStack()
        {
            Stack<int> numeros = new Stack<int>();

            numeros.Push(1);
            numeros.Push(2);
            numeros.Push(3);
            numeros.Push(4);
            numeros.Push(5);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            int popedNumber = numeros.Pop();

            Console.WriteLine(popedNumber);
        }
    }
}
