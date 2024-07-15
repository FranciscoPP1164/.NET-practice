namespace Colecciones
{
    class ColeccionList
    {
        public ColeccionList()
        {
            //Las listas es el tipo de coleccion basica, es una coleccion de elementos del mismo tipo sin ordenar
            List<int> numeros = new List<int>();

            numeros.Add(5);
            numeros.Add(3);
            numeros.Add(6);

            //El codigo anterior se puede escribir de la siguiente forma
            // List<int> numeros = [4,5,6];

            numeros.RemoveAt(numeros.Count - 1);

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }

        }
    }
}
