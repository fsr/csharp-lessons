EineKlasse obj = new EineKlasse();
// Delegate-Variable erstellen und befuellen.
EinDelegate variable = obj.EineMethode;
variable += obj.AndereMethode;
// Aufruf des Delegates.
variable(7.21314);