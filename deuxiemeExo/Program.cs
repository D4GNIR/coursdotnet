// See https://aka.ms/new-console-template for more information
const int nbMin = 1;
const int nbMax = 10;
const int mystere = 8;
Console.WriteLine("Veuillez saisir votre prénom");
string prenom = Console.ReadLine();

bool success = false;
List<int> nbJoue = new List<int>();
string indication = "";

while (success != true)
{
    Console.Clear();
    Console.WriteLine(indication);
    Console.WriteLine($"Nombre déjà joués : ");
    foreach (int nbr in nbJoue)
    {
        Console.WriteLine($" {nbr} ");
    }
    int nb = 0;
    while (nb < nbMin || nb > nbMax)
    {
        Console.WriteLine($"Veuillez entrer un nombre entre {nbMin} et {nbMax}");
        try
        {
            nb = int.Parse(Console.ReadLine());
        }
        catch 
        {
            nb = 0;
        }
    }
        
    nbJoue.Add(nb);
    if (nb == mystere)
    {
        success = true;
        Console.WriteLine("Vous avez gagné!");
    }else
    {
        if(nb > mystere){
            indication = "Le nombre mystere est plus petit";
        }else{
            indication = "Le nombre mystere est plus grand";
        }
    }
}


