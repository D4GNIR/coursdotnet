// See https://aka.ms/new-console-template for more information

string[] valeurs = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Veuillez saisir la valeur {i + 1}");
    valeurs[i] = Console.ReadLine();
}



for (int i = 0; i < 3; i++)
{
    Console.WriteLine(valeurs[i]);
}