//Basisklasse
public class Geld
{
	public void pay() { }
}

//Tochterklasse
public class Dollar : Geld
{
	public void pay() {	}
}

//Aufruf
Geld Banknote1 = new Geld()
Geld Banknote2 = new Dollar()

//ruft Geld.pay() auf
Banknote1.pay()

//ruft Dollar.pay() auf
Banknote2.pay()