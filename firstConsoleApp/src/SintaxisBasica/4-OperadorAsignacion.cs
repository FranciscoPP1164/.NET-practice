namespace SintaxisBasica
{
    class OperadorAsignacion
    {
        public OperadorAsignacion()
        {
            //el operador "=" se usar para asignar el valor o la referencia de una expresion a una variable.

            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            Console.WriteLine(edadPersona1);
            Console.WriteLine(edadPersona2);
            Console.WriteLine(edadPersona3);
            Console.WriteLine(edadPersona4);

            //esta sintaxis es permitida, solo las variables a las que se les asigno un valor son inicializadas.

            int edadPersona5, edadPersona6 = 27, edadPersona7, edadPersona8 = 21;

            //declaración impicita es usar la palabra reservada "var" y asigne en tiempo de compilacion el tipo de dato a la variable.

            var edadPersona9 = 11;
        }
    }
}
