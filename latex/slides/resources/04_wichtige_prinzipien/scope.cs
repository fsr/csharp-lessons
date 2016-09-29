int eineVariable = 7;
for(int zaehler = 0; zaehler < 9; zaehler++)
{
    // zaehler und einString sind bloss in diesem Block
    // nutztbar, aber nicht ausserhalb.
    string einString = "Hallo";    
}

if(eineVariable <= 10)
{
    // Hier gibt es zaehler nicht, aber es kann eine neue
    // Variable mit selben Namen erstellt werden.
    float zaehler = 0.0042;
}