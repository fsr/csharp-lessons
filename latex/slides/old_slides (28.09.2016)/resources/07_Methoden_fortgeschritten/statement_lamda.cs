// Methoden ohne Parameter brauchen ()
LeerDelegate var1 = () =>
    {
        string s = "Hallo World"; 
        Console.WriteLine(s);
    }
var1();
// Ein Parameter braucht keine () ausser, wenn der Typ
// mit angegeben wird
EinDelegate var2 = x => { x *= x; x *= x; return x; }
float z = var2(2);