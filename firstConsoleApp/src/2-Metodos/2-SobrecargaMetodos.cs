namespace Metodos
{
    class SobrecargaMetodos
    {
        public SobrecargaMetodos()
        {
            Suma(4, 5);
            Suma(4, 5, 3);
            Suma(1.2, 5, 3);
            Suma(4, 5, 3, 2);
        }

        public int Suma(int num1, int num2) => num1 + num2;

        public int Suma(int num1, int num2, int num3) => num1 + num2 + num3;

        public double Suma(double num1, int num2, int num3) => num1 + num2 + num3;

        public int Suma(int num1, int num2, int num3, int num4) => num1 + num2 + num3 + num4;

    }
}
