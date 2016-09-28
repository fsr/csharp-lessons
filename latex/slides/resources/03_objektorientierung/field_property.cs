class EineKlasse 
{
    int EinFeld;
    int EineEigenschaft 
    {
        get 
        { 
            return EinFeld; 
        }
        private set 
        { 
            // Moegliche Berechnungen
            EinFeld = value; 
        }    
    }
}