using System.Diagnostics.Contracts;

namespace POO
{
    partial class Coche
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;
        private static int contadorDeObjetos = 0;

        public Coche(double largo, double ancho, bool climatizador, string tapiceria)
        {
            ruedas = 4;
            this.largo = largo;
            this.ancho = ancho;
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
            contadorDeObjetos++;
        }
    }

    partial class Coche
    {
        public int GetRuedas() => ruedas;

        public void SetRuedas(int ruedas) => this.ruedas = ruedas;

        public string GetInfoCoche() => $"Ruedas:{ruedas}\nLargo:{largo}\nAncho:{ancho}\nClimatizador:{climatizador}\nTapiceria:{tapiceria}";

        public static int getNumeroDeObjetos() => contadorDeObjetos;
    }
}
