EineKlasse obj = new EineKlasse();
int zahlen[] = { 2, 4, 7 };
// Es wird die Referenz der dritten Zahl uebergeben.
obj.EineMethode(ref zahlen[2]);
// Eine Auflistung an ints wird uebergeben.
obj.AndereMethode(2, 3, 6, 8345);
// Das Array mit ints wird uebergeben.
obj.AndereMethode(zahlen);