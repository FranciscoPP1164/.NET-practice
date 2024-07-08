namespace DelegadosPredicadosLambdas
{
    class Predicados
    {
        Predicate<int> predicado;

        public Predicados()
        {
            List<int> numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            predicado = new Predicate<int>(IsPair);

            bool existPairs = numeros.Exists(predicado);

            Console.WriteLine(existPairs);

            List<int> filteredList = numeros.FindAll(predicado);

            foreach (int number in filteredList)
            {
                Console.WriteLine(number);
            }
        }

        public bool IsPair(int num)
        {
            return num % 2 == 0;
        }
    }
}
