public class AndereKlasse
{
    public AndereKlasse(EineKlasse var)
    {
        var.EinEvent += eineMethode;
        var.EinEvent += zweiteMethode;
    }

    private eineMethode(object sender, EventArgs args)
    {   /*Code*/   }
    private zweiteMethode(object sender, OwnEventArgs args)
    {   /*Code*/   }
}