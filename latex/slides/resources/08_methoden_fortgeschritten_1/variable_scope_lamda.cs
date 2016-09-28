LeerDelegate var0;
EinDelegate var1;

// Alle Variablen in dieser Methode koennen in Lamdas 
// genutzt werden.
private void EineMethode(int zahl)
{
    // Muss vorher einen Wert haben.
    int val = 7;
    var0 += () => Console.WriteLine(zahl + "-" + val);
    var1 += (float x) =>
        {
            // Kann ueberschrieben werden.
            val *= x;
            val -= zahl;
            return val; 
        };
}