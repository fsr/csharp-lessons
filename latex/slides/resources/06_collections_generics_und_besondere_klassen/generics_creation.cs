public class EineKlasse 
{ }
public class ZweiteKlasse : EineKlasse
{ }
// Generische Klasse mit 2 Typparametern, wobei der erste
// eingeschraenkt ist.
public class AndereKlasse<T, U> where T : EineKlasse
{ }