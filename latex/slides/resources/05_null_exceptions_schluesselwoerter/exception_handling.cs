try 
{
    // Dieser Code wird "ausprobiert", bei einem
    // Fehler werden die catch-Bloecke genutzt.    
}
catch(NullReferenceException e)
{
    // Block fuer Fehler mit einem null-Objekt
}
catch(Exception e)
{
    // Block fuer alle Fehler, die es gibt.
}
finally
{
    // Bereinigungsblock. Wird immer aufgerufen.
}