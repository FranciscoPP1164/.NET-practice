namespace POO
{
    class ConverorPesoColombianoDolar
    {
        private double pesoColombiano = 0.00026;

        public double Cast(double cantidadPesosColombianos)
        {
            return cantidadPesosColombianos * pesoColombiano;
        }

        public void SetPesoColombiano(double nuevoValorPesoColombiano)
        {
            pesoColombiano = nuevoValorPesoColombiano;
        }
    }
}
