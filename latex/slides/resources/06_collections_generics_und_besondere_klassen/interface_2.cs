public interface PhysikInterface
{
	public void Flugkurve();
}

public class Ball : PhysikInterface
{
    public void Flugkurve() { /* Code */ }
}

public class Stein : PhysikInterface
{
	public void Flugkurve() { /* Code */ }
}

//Anwendung
static void Main()
{
	PysikInterface Wurfobjekt = new Stein;
	Wurfobjekt.Flugkurve();
}