

//Zadanie 3


using System.Security.Cryptography;

Dictionary<string, int> ceny = new Dictionary<string, int>
{
    { "Mikstura", 15 },
    { "Pochodnia", 5 },
    { "Miecz", 40 }
};

Console.WriteLine($"Liczba pozycji u kupca: {ceny.Count}");

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value} sztuk złota");
}

Console.Write("Podaj przedmiot, aby sprawdzić czy jest w cenniku:");

string sprawdzany = Console.ReadLine()!;

if (ceny.ContainsKey(sprawdzany))
{
    Console.WriteLine($"Przedmiot jest na stanie i kosztuje {ceny[sprawdzany]}");
}
else
{
    Console.WriteLine("Przedmiotu nie ma na stanie");
}

ceny["Mikstura"] = 12;

Console.WriteLine("Cennik po zmianach:");

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value} sztuk złota");
}

