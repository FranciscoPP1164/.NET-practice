namespace SintaxisBasica
{
    class TiposDeDatos
    {
        static void Main()
        {
            /*
            existen dos grandes grupos de tipos

            Por Valor: son aquellos culla variable almacena un valor puntual

            Por referencia: son aquellos culla variabla almacena una referencia o direccion del valor que representa
            */

            //Tipos por valor

            //Primitivos
            //Enteros: son valores numericos enteros
            //Con signo
            //-128 a 127
            sbyte sbyteNumber = -14;

            //-32768 a 32767
            short shortNumber = 14000;

            //-2.147.483.648 a 2.147.483.647
            int intNumber = -121234534;

            //-9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            long longNumber = 232345645902;

            //Sin signo
            //0 a 255
            byte byteNumber = 14;

            //0 a 65.535
            ushort ushortNumber = 14;

            //0 a 4.294.967.295
            uint uintNumber = 14;

            //0 a 18.446.744.073.709.551.615
            ulong ulongNumber = 14;

            //Reales: son valores numericos reales
            //±1,5 x 10^-45 a ±3,4 x 10^38
            float floatNumber = (float)234.345;

            //De ±5,0 × 10^−324 a ±1,7 × 10^308
            double doubleNumber = 23423.234839483;

            //De ±1,0 x 10^-28 to ±7,9228 x 10^28
            decimal decimalNumber = (decimal)23423.23892792794579475924590;

            //Char:es un tipo que puede representar cualquier caracter dentro del UTF-16
            char char1 = 'A';
            char char2 = 'B';
            char char3 = 'a';
            char char4 = '1';
            char char5 = '$';

            //Booleanos: son valores logicos
            //las variables de tipo booleano solo pueden tener dos valores: true or false
            bool falseBoll = false;
            bool trueBoll = true;
        }
    }
}
