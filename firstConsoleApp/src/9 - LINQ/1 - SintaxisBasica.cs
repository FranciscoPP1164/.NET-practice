namespace LINQ
{
    class SintaxisBasica
    {
        public SintaxisBasica()
        {
            //LINQ nos permite hacer consultas imperativas faciles de leer para realizar consultas a diferentes tipos de fuentes de datos
            //Su ventaja mas grande es que la sintaxis de consultas que usa es la misma para todos los tipos de fuentes de datos, sea, un JSON, una lista, una base de datos, etc...
            //Tiene una sintaxis muy similar a la sintaxis de SQL

            int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            //Cuando se declara la consulta solamente se esta creando la instruccion que se debe seguir para traer los datos
            IEnumerable<int> numerosPares = from numero in numeros where numero % 2 == 0 select numero;

            //No es si no hasta que se usa como un objeto iterable que se ejecuta la consulta y esta se realiza de manera diferida, es decir
            //A medida que se lee cada registro se ejecuta una iteracion que permite la lectura de esta y no es necesario esperar a que se
            //Lean todos los registros para hacer uso de estos
            foreach (int numero in numerosPares)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
