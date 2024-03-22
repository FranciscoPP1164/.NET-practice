namespace SintaxisBasica
{
    class CastingDeTipos
    {
        public CastingDeTipos()
        {

            //el casting explicito es especificar al compilador a que tipo se tendra que convertir un valor de un tipo diferente para ser
            //asignado a una variable del tipo a convertir, es posible que se pierda información en el proceso.

            double temperatura = 34.5;
            int temperatura2;
            temperatura2 = (int)temperatura;

            //el casting implicito es cuando el compilador infiere una conversion facil de realizar que no representa perdida de datos.
            int numeroPersonas = 34;
            double promedioPersonas;
            promedioPersonas = numeroPersonas;

            //conversion de String a number
            String miTexto = "123";
            //el metodo Parse() esta disponible en todas las clases de los tipos de datos y permite hacer un casting de una variable a ese tipo
            int miNumero = int.Parse(miTexto);
        }
    }
}
