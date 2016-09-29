int note = 2;
string noteStr = "";
// Hier beginnt die switch-case-Verzweigung.
switch (zahl)
{
    case 1:
        noteStr = "Sehr gut";
        break;
    case 2:
        noteStr = "gut";   
        break;
    // ...
    default:
        noteStr = "Diese Note gibt es nicht.";
        break;
}