namespace Colecciones
{
    class ColeccionDictionary
    {
        public ColeccionDictionary()
        {
            Dictionary<string, int> numeros = new Dictionary<string, int>();

            numeros.Add("uno", 1);
            numeros.Add("dos", 2);
            numeros.Add("tres", 3);
            numeros.Add("cuatro", 4);
            numeros.Add("cinco", 5);

            //La instruccion anterior se puede reescribir asi

            // Dictionary<string, int> numeros = new Dictionary<string, int>
            // {
            //     { "uno", 1 },
            //     { "dos", 2 },
            //     { "tres", 3 },
            //     { "cuatro", 4 },
            //     { "cinco", 5 }
            // };

            foreach (KeyValuePair<string, int> kvp in numeros)
            {
                Console.WriteLine(kvp.Value);
            }

            bool wasRemovedNumber = numeros.Remove("tres");

            Console.WriteLine("Despues de remover");

            foreach (KeyValuePair<string, int> kvp in numeros)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}
