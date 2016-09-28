// Ein leeres Array initiallisieren.
int[][] zahlenListe1 = new int[2][];
zahlenListe1[0] = new int[7];
zahlenListe1[1] = new int[18];
// Ein Array mit Inhalt initialisieren.
int[][] zahlenListe2 = { new int[] { 1, 1 }, new int[] { 2, 2 } };
// Auf ein Element des Arrays zugreifen.
zahlenListe1[0][1] = 6 + zahlenListe2[1][1];