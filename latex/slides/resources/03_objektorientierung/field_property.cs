class EineKlasse 
{
    int EinFeld;
    int EineEigenschaft 
    {
        get 
        { 
            return EinFeld; 
        }
        set 
        { 
            // Moegliche Berechnungen
            EinFeld = value; 
        }    
    }
}