Dictionary<string, float> einDict = new Dictionary<string, float>();
// Paare werden hinzugefuegt.
einDict.Add("Hallo", 2.5436);
einDict.Add("Tschuess", 2424423.2);
// Zugriff auf ein Element.
einDict["Hallo"] = 7;
// Ein Paar entfernen.
einDict.Remove("Tschuess");