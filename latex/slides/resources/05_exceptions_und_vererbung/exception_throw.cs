public class MeineException : Exception
{
    public MeineException()
    {   /*Code*/   }
    public MeineException(string message) 
        : base(message)
    {   /*Code*/   }
    public MeineException(string message, Exception innerException) 
        : base(message, innerException)
    {   /*Code*/   }
}
public class EineKlasse
{
    public void EineMethode() 
    {
        throw new MeineException("Das ist meine Exception");
    }
}