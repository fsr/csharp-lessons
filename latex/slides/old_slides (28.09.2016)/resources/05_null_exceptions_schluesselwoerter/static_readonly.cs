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
    // Statische Methode, kann nicht die beiden strings benutzen.
    public static string EineMethode()
    {
        EineVariable = 42;
    }
}