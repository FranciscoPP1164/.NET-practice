namespace SintaxisBasica
{
    class Constantes
    {
        public Constantes()
        {
            //Las constantes son variables que no pueden ser reasignada durante la ejecución del programa
            //las constantes se tienes que declarar e inicializar en la misma linea, porque se resuelven en tiempo de compilacion.
            const int MI_NUMERO = 15;

            //esta es otra forma de dar uso al metodo WriteLine de la clase Console
            Console.WriteLine("Mi numero es {0}", MI_NUMERO);
        }
    }
}
