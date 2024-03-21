namespace SintaxisBasica
{
    class OperadoresAritmeticos
    {
        static void Main()
        {
            //Si se intenta hacer una operacion aritmetica con cualquier tipo de dato que no sea numerico lanzara una excepcion en tiempo
            //de compilacion a excepcion del operador "+" que se usa para concatenar strings.

            int suma = 3 + 3;

            int resta = 4 - 2;

            int multiplicacion = 3 * 5;

            float division = 3 / 4;

            int modulo = 10 % 5;

            suma++;

            resta--;

            suma += 5;

            resta -= 4;
        }
    }
}
