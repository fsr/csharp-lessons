public class EineKlasse
{
	public List<int> elements;
	public EineKlasse(int anzahl) 
	{ elements = new List<int>(anzahl);	}
    // Eine Ueberladung fuer + und true.
    public static EineKlasse operator +(EineKlasse a, EineKlasse b)
	{ return new EineKlasse(a.elements.Count + b.elements.Count); }
    public static bool operator true(EineKlasse obj)
	{ return elements.Count > 0 ? true : false; }
}