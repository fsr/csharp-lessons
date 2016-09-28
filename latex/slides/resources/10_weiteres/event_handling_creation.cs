public class OwnEventArgs : EventArgs
{
    public string Output;
    public OwnEventArgs(string output)
    {
        Output = output;
    }
}

public class EineKlasse
{
    public event EventHandler<OwnEventArgs> EinEvent;

    // ...
}
