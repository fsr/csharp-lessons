// Methoden ohne Parameter brauchen ()
LeerDelegate var1 = () => "Hallo";
// Ein Parameter braucht keine () ausser, wenn der Typ
// mit angegeben wird
EinDelegate var2 = (float val) => val < 100;
// Zwei Parameter brauchen ()
ZweiDelegate var3 = (int1, int2) => int1 - int2;