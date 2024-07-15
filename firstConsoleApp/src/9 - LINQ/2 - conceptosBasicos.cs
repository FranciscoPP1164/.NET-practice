namespace LINQ;

class ConceptosBasicos
{
    public ConceptosBasicos()
    {
        int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        string[] ciudades = ["Cali", "Bogota", "Medellin", "Cartagena", "Villavicencio", "San Andres", "Santa Marta"];

        //Los datos devueltos por la consulta no tiene porque ser los mismo de ingreso en cuanto a tipo o formato
        IEnumerable<string> numerosPares = from numero in numeros where numero % 2 == 0 select $"El numero selecto es {numero}";

        foreach (string numero in numerosPares)
        {
            Console.WriteLine(numero);
        }

        //Se pueden recuparar valores singleton de las consultas, como por ejemplo el numero de elementos que cumplen con una condicion
        IEnumerable<int> numerosImpares = from numero in numeros where numero % 2 != 0 select numero;
        int countNumerosImpares = numerosImpares.Count();

        // Las consultas siempre deben terminar con una clausula group o select
        //La interfaz IGrouping reprensenta un conjunto de elementos agrupados el primer tipo representa el tipo del indice de agrupacion y el segundo el tipo de los elementos
        IEnumerable<IGrouping<char, string>> group = from ciudad in ciudades group ciudad by ciudad[0];

        //La clausula orderby permite ordenar los elementos de formas acendente o descented
        IEnumerable<int> select = from numero in numeros orderby numero descending select numero;

        //La clausula into permite almacenar el resultado de una subconsulta de forma temporal
        IEnumerable<IGrouping<char, string>> into =
        from ciudad in ciudades
        group ciudad by ciudad[0] into ciudadGroup
        select ciudadGroup;
    }
}

