using System.Collections;

namespace SintaxisAvanzada;

//Toda clase que implemente la interfaz IEnumerable<T> o similares debera implementar un metodo GetEnumerator() que definira el comportamiento de la clase cuando sea iterada
class Iterators : IEnumerable<int>
{
    private EnumeratorType<int> Enumerator;

    public Iterators()
    {
        Enumerator = new EnumeratorType<int>([1, 2, 3, 4, 5]);
    }

    //Todo metodo que devuelve un tipo IEnumerable<T> podra ser iterado en cualquier tipo de estructura ciclica y tratado como un array de T tipo
    public IEnumerable<int> Iterate()
    {
        yield return 0;
        yield return 1;
        yield return 2;
        yield return 3;
        yield return 4;
        yield return 5;
        yield return 6;
        yield return 7;
        yield break;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return Enumerator;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class EnumeratorType<T> : IEnumerator<T>
{
    private T[] List;
    private int index = -1;
    private T _current;

    public EnumeratorType(T[] list)
    {
        List = list;
        _current = List[0];
    }

    public bool MoveNext()
    {
        if (++index >= List.Length)
        {
            return false;
        }
        _current = List[index];
        return true;
    }

    public void Reset()
    {
        index = -1;
    }

    public void Dispose()
    {

    }

    public T Current
    {
        get => _current;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }
}
