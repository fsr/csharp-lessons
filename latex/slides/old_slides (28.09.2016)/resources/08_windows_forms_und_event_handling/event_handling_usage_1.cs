public class AndereKlasse
{
    public AndereKlasse(EineKlasse einObject)
    {
        einObject.EinEvent += eineMethode;
        einObject.EinEvent += zweiteMethode;
    }

    private eineMethode(object sender, OwnEventArgs args)
    {   /*Code*/   }
    private zweiteMethode(object sender, OwnEventArgs args)
    {   /*Code*/   }
}