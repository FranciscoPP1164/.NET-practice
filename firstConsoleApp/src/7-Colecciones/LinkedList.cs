namespace Colecciones
{
    class ColeccionLinkedList
    {
        public ColeccionLinkedList()
        {

            //Las Listas Linkeadas son listas iguales a las Listas en cuanto a funcionamiento
            //Sin embargo cada elemento de la lista se almacena un nodo el cual consta del dato y dos links los cuales apuntan al nodo anterior y al siguiente
            //Cuando se elimina o se agrega un nodo los elementos de la lista no actualiza sus pocisiones en momoria como lo hacen normalmente
            //Si no que actualizan los links que apuntan al elemento anterior y posterior a la modificacion.
            //Esto hace que sean mucho mas utiles en listas las cuales sufren de actualizaciones constantemente

            LinkedList<int> numeros = new LinkedList<int>();

            numeros.AddFirst(10);
            numeros.AddFirst(20);
            numeros.AddFirst(30);
            numeros.AddFirst(40);

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
