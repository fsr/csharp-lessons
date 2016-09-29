public abstract class EineKlasse
{
    // Eine abstrakte Methode ohne Koerper.
    public abstract int EineMethode();
    public virtual float AndereMethode()
    {
        // Code
    }
}

public class AndereKlasse : EineKlasse
{
    // Diese Methode muss implementiert werden,
    // die "AndereMethode" nicht.
    public override float EineMethode() 
    {
        // Code
    }
}