public class EineKlasse
{
    public event EventHandler<OwnEventArgs> EinEvent;

    public EventMethode()
    {
        // ..
        if(EinEvent != null)
            EinEvent(this, new OwnEventHandler("Hallo Welt"));
    }
}
