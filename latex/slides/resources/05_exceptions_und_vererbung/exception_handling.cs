try 
{
    // Dieser Code wird "ausprobiert", bei einem
    // Fehler werden die catch-Bloecke genutzt.    
}
catch(NullReferenceException e)
{
    // Block fuer Fehler mit einem null-Objekt
}
catch(MeineException e)
{
    // Block fuer meine eigens erstelle Exception.
}
finally
{
    // Wird immer aufgerufen.
}