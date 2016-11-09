public class EineKlasse 
{
    // Statische Variable
    public static int EineVariable;
    // Readonly Variablen mit direkter Deklaration und
    // ueber den Konstruktor.
    private readonly string EinString = "Hallo";
    private readonly string AndererString;
    
    public EineKlasse() 
    {
        AndererString = "Tschuess";
    }
}

public class ZweiteKlasse
{
	public static string SetVariable()
	{
		EineKlasse.EineVariable = 42;
	}
}