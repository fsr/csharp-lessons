// Methoden ohne Parameter brauchen ()
LeerDelegate var0 = () =>
    {
        string s = "Hallo World"; 
        Console.WriteLine(s);
    };
var0();
// Ein Parameter braucht keine () ausser, wenn der Typ
// mit angegeben wird
EinDelegate var1 = x => { x *= x; x *= x; return x; };
float z = var1(2);