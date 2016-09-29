public interface EinInterface
{
    // Nur Signaturen ohne Koerper.
    public string EinString { get; set; }
    public bool EineMethode();
}

public class EineKlasse : EinInterface
{
    // Diese Member muessen nun implementiert werden.
    public string EinString 
    {
        get {   /*Code*/   }
        set {   /*Code*/   }
    }
    public bool EineMethode() 
    {
        // Code    
    }
}