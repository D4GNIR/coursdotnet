// See https://aka.ms/new-console-template for more information
const int majorite = 18;
Console.WriteLine("Veuillez saisir votre prénom");
string prenom = Console.ReadLine();
Console.WriteLine("Veuillez saisir votre âge");
string age = Console.ReadLine();
int ageInt = int.Parse(age);
Console.WriteLine($"Bonjour {prenom}, vous avez {ageInt} ans.");
Console.WriteLine("Bonjour " + prenom +", vous avez "+ ageInt +" ans.");

if (ageInt >= majorite)
{
    Console.WriteLine("Vous êtes Majeur");
}else
{
    Console.WriteLine("Vous êtes Mineur");
}

