// Methoden ohne Parameter brauchen ()
LeerDelegate var1 = () =>
    {
        string s = "Hallo World"; 
        Console.WriteLine(s);
    }
// Ein Parameter braucht keine () ausser, wenn der Typ
// mit angegeben wird
EinDelegate var2 = val => { x *= x; x *= x; return x; }