namespace SintaxisAvanzada;

enum Operation : byte
{
    SystemTest = 0,
    Start = 1,
    Stop = 2,
    Reset = 3,
}

class PatternMatching
{
    //Los pattern matching permite realizar validaciones logicas con expresiones declarativas para ver si
    //un valor cumple con cierto patron
    public void NullCheck()
    {
        int? number = 12;

        //Si la variable number cumple con el patron de ser de tipo entero se crea una variable local en el
        //scope del bloque de acersion del condicional if llamada temporalNumber la cual almacena el valor de number
        //de no cumplir con el patron ejecuta el bloque else
        if (number is int temporalNumber)
        {
            Console.WriteLine(temporalNumber);
        }
        else
        {
            Console.WriteLine("Numero nulo");
        }

        string? message = "Este es un texto";

        //valida si la variable no tiene un valor nulo
        if (message is not null)
        {
            Console.WriteLine(message);
        }
    }

    public T MidPoint<T>(IEnumerable<T> sequence)
    {
        //Validar si el parametro sequence implementa la interfaz IList<T> y almacena el valor en list
        if (sequence is IList<T> list)
        {
            //Uso de la propiedad Count de la interfaz IList<T>
            return list[list.Count / 2];
        }
        //valida si sequence es nulo y lanza una excepcion
        else if (sequence is null)
        {
            throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
        }
        //En caso de no implementar IList<T> usa el metodo Count() de la interfaz IEnumerable<T>
        else
        {
            int halfLength = sequence.Count() / 2 - 1;
            if (halfLength < 0) halfLength = 0;
            return sequence.Skip(halfLength).First();
        }
    }

    public string PerformOperation(Operation command) => command switch
    {
        Operation.SystemTest => "Corriendo diagnostico del sistema",
        Operation.Start => "Iniciando sistema",
        Operation.Stop => "Parando sistema",
        Operation.Reset => "Reiniciando sistema",
        _ => "Operacion no disponible",
    };

    public string WaterState(byte tempInFahrenheit) =>
    tempInFahrenheit switch
    {
        (> 32) and (< 212) => "liquid",
        < 32 => "solid",
        > 212 => "gas",
        32 => "solid/liquid transition",
        212 => "liquid / gas transition",
    };
}
