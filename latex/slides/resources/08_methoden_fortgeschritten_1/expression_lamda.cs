// Methoden ohne Parameter brauchen ()
LeerDelegate var1 = () => "Hallo";
string s = var1() + " Welt!";
// Ein Parameter braucht keine () ausser, wenn der Typ
// mit angegeben wird
EinDelegate var2 = (float val) => val < 100;
bool b = var2(20.0f)
// Zwei Parameter brauchen ()
ZweiDelegate var3 = (int1, int2) => int1 - int2;
int z = var3(76, 24);