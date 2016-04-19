// Eigene Liste mit maximale 100 Elementen.
public class EigeneListe<T>
{
    // Private Datenstruktur.
    private T[] array = new T[100];
    // Hier beginnt der Indexer.
    private T this[int index]
    {
        get 
        {
            return array[index];    
        }
        set
        {
            array[index] = value;
        }
    }
}