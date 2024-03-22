namespace SintaxisBasica
{
    class OperadoresAritmeticos
    {
        public OperadoresAritmeticos()
        {
            //Si se intenta hacer una operacion aritmetica con cualquier tipo de dato que no sea numerico lanzara una excepcion en tiempo
            //de compilacion a excepcion del operador "+" que se usa para concatenar strings.

            int suma = 3 + 3;

            int resta = 4 - 2;

            int multiplicacion = 3 * 5;

            float division = 3 / 4;

            int modulo = 10 % 5;

            //cuando los operadores se usan como sufijo primero se lee el valor de la variable y luego se aplica la operacion
            suma++;

            resta--;

            //cuando los operadores se usan como prefijo primero se aplica la operacion y luego se lee el valor de la variable
            ++suma;

            --suma;

            suma += 5;

            resta -= 4;
        }
    }
}
