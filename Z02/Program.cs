

//Zadanie 2


List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Pochodnia"
};

Console.WriteLine($"Plecak: {plecak.Count}/5");

for (int i = 0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plecak[i]}");
}

plecak.Add ("Klucz");
Console.WriteLine($"Znalazłeś: {plecak[3]}");

Console.WriteLine($"Plecak: {plecak.Count}/5");

for (int i = 0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plecak[i]}");
}

if (plecak.Contains("Mikstura"))
{
    plecak.Remove("Mikstura");
    Console.WriteLine("Użyłeś mikstury.");
}
else
{
    Console.WriteLine("Nie masz mikstury do wypicia.");
}

Console.WriteLine($"Plecak: {plecak.Count}/5");

for (int i = 0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plecak[i]}");
}