namespace SintaxisAvanzada;

class Indexers
{
    public Dictionary<string, int> storage;

    public Indexers()
    {
        storage = [];
    }

    //Un indexer permite describir como se debe comportar un objeto cuando es tratado como un array
    public int this[string key]
    {
        get
        {
            storage.TryGetValue(key, out int output);
            return output;
        }
        set => storage.Add(key, value);
    }
}
