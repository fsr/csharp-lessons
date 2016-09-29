EineKlasse obj = new EineKlasse();
// Delegate-Variable erstellen und befuellen.
EinDelegate variable = obj.EineMethode;
// Aufruf des Delegates.
int erg = variable(24);
if(erg == 76)
{   /* Code */   }