// Daten
int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

// Queryerstellung
var numQuery =
    from num in numbers
    where (num % 2) == 0
    select num;

// Queryausfuehrung
foreach (int num in numQuery)
{
    Console.WriteLine(num);
}