// Methoden ohne Parameter brauchen ()
LeerDelegate var0 = () => "Hallo";
string s = var0() + " Welt!";
// Ein Parameter braucht keine () ausser, wenn der Typ
// mit angegeben wird
EinDelegate var1 = (float val) => val < 100;
bool b = var1(20.0f)
// Zwei Parameter brauchen ()
ZweiDelegate var2 = (int1, int2) => int1 - int2;
int z = var2(76, 24);