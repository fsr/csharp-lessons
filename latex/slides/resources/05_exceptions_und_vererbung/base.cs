public EineKlasse 
{
    public EineKlasse(int parameter1, int parameter2)
    {   /* Code */   }
    public virtual float EineMethode(int a)
    {   /* Code */   }
}

public AndereKlasse : EineKlasse
{
    public AndereKlasse(int par1, int par2, string par3)
        : base(par1, par2)
    {   /* Anderer Code */   }
    public override float EineMethode(int a)
    {
        // Hier wird die Basismethode aufgerufen.
        base.EineMethode(a - 5);
        // Neuer Code
    }
}