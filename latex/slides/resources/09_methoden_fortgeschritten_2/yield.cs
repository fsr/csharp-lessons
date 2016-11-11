public static IEnumerable<int> Power(int number, int exponent)
{
    int result = 1;

    for (int i = 0; i < exponent; i++)
    {
        result = result * number;
        yield return result;
    }
}

public IEnumerable<int> Methode()
{
    yield return 7;
    yield return 42;
}