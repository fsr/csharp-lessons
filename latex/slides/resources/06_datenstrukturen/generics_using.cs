// Zwei Moeglichkeiten zur Erstellung einer generischen 
// Klasse.
AndereKlasse<EineKlasse, string> obj = 
    new AndereKlasse<EineKlasse, EineKlasse>();
AndereKlasse<ZweiteKlasse, int> obj = 
    new AndereKlasse<ZweiteKlasse, int>();