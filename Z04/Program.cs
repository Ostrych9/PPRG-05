

//Zadanie 4


using System.Runtime.CompilerServices;

Console.Write("Wybierz liczbę tur (1-10):");
int iletur = int.Parse(Console.ReadLine()!);

int[] tury = new int[iletur];

for (int i = 0; i < tury.Length; i++)
{
    Console.WriteLine($"Ile złota zdobyłeś w turze {i + 1}?");
    tury[i] = int.Parse(Console.ReadLine()!);
}

int suma = 