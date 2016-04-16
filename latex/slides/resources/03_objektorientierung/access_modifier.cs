// Es kann jeder diese Klasse benutzen.
public EineKlasse
{
    // Diese beiden koennen nur innerhalb der Klasse benutzt 
    // werden.
    private int einFeld;
    protected string einAnderesFeld;
    
    // Jeder kann eine Instanz dieser Klasse erstellen.
    public EineKlasse() 
    { }
    
    // Diese Methode kann von ueberall benutzt werden, 
    // solange es einen Verweis auf eine Instanz dieser 
    // Klasse gibt.
    public void EineMethode()
    { }
}