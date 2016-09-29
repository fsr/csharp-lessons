// Durch Polymorphie ist der Typ im Code "EineKlasse"
// aber zur Laufzeit "AndereKlasse".
EineKlasse variable = new AndereKlasse();
// Umwandlung der Varaible in "AndereKlasse".
AndereKlasse andereVariable = (variable as AndereKlasse);
