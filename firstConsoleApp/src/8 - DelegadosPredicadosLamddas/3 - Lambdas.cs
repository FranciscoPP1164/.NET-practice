namespace DelegadosPredicadosLambdas
{
    //Las lambdas son una expresion moderna para crear delegados
    //En esencia son Arrow Functions de JavaScript
    class Lambdas
    {
        public Lambdas()
        {
            List<int> numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            bool existPairs = numeros.Exists(num => num % 2 == 0);

            Console.WriteLine(existPairs);

            List<int> filteredList = numeros.FindAll(num => num % 2 == 0);

            foreach (int number in filteredList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
