class EineKlasse 
{
    int einFeld;
    int EineEigenschaft 
    {
        get 
        { 
            return einFeld; 
        }
        private set 
        { 
            // Moegliche Berechnungen
            einFeld = value + 42; 
        }    
    }
}