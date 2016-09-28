LeerDelegate var1;
EinDelegate var2;

// Alle Variablen in dieser Methode koennen in Lamdas 
// genutzt werden.
private void EineMethode(int zahl)
{
    // Muss vorher einen Wert haben.
    int val = 7;
    var1 += () => Console.WriteLine(zahl + "-" + val);
    var2 += (float x) =>
        {
            // Kann ueberschrieben werden.
            val *= x;
            val -= zahl;
            return val; 
        };
}