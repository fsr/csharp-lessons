EineKlasse obj = new EineKlasse();
int i;
string einString;

// Uebergabe als out Parameter.
obj.EineMethode(out i, out einString);

// Jetzt ist der string nicht mehr null, sondern "Hallo"
// Und i ist 42