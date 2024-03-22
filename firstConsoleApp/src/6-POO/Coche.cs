namespace POO
{
    partial class Coche
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

        public Coche(double largo, double ancho, bool climatizador, string tapiceria)
        {
            ruedas = 4;
            this.largo = largo;
            this.ancho = ancho;
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
    }

    partial class Coche
    {
        public int GetRuedas()
        {
            return ruedas;
        }

        public void SetRuedas(int ruedas)
        {
            this.ruedas = ruedas;
        }

        public string GetInfoCoche()
        {
            return $"Ruedas:{ruedas}\nLargo:{largo}\nAncho:{ancho}\nClimatizador:{climatizador}\nTapiceria:{tapiceria}";
        }
    }
}
