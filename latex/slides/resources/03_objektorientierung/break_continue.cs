int erg = 0;

for(int zaehler = 0; zaehler < 10; zaehler++)
{
    // Es werden nur ungerade Zahlen erlaubt.
    if(zaehler % 2 == 0)
        continue;
    erg += zaehler;
    // Falls die Variable erg 16 ist, wird die ganze 
    // Schleife beendet.
    if(erg == 16)
        break;
}