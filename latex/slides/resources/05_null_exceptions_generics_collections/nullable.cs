// Wertetypen als Nullable
int? eineVariable = null;
// Nun hat er einen Wert.
eineVariable = 0;
// Man kann schauen, ob es einen Wert hat.
if(eineVariable.HasValue)
{
    // Man kann nur per Value auf den Wert zugreifen.
    eineVariable.Value += 2;    
}