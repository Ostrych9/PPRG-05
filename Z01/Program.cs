

//Zadanie 1


int[] zlotoWTurach = { 5, 12, 0, 8, 15 };

for (int i = 0; i < zlotoWTurach.Length; i++)
{
    Console.WriteLine($"{i + 1} Tura: {zlotoWTurach[i]} sztuk złota.");
}

int suma = 0;

foreach (int zloto in zlotoWTurach)
{
    suma += zloto;
}

double srednia = (double)suma / zlotoWTurach.Length;

Console.WriteLine($"\nSuma: {suma}");
Console.WriteLine($"\nŚrednia: {srednia:F2}");

int bogate = 0;

foreach (int zloto in zlotoWTurach)
{
    if (zloto >= 10)
    {
        bogate++;
    }
}

Console.WriteLine($"Tur z przynajmniej 10 złota: {bogate}.");

for (int i = zlotoWTurach.Length - 1; i >= 0; i--)
{
    Console.Write(zlotoWTurach[i] + " ");
}