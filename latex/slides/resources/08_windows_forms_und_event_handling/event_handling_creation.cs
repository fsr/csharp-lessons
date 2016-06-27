public class OwnEventArgs : EventArgs
{
    public string Output;
    public OwnEventArgs(string out)
    {
        Output = out;
    }
}

public class EineKlasse
{
    public event EventHandler<OwnEventArgs> EinEvent;

    // ...
}
