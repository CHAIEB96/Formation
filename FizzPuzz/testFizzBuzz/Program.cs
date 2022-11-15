

//Initialization
using System.IO.Pipes;


Console.WriteLine("***********FizzBuzz***********");


int PlayerNumber = 0;

string name = GetPlayerName();
List<string> listPlayer = ListDemo();
ShowPlayerList(listPlayer);


///Fonction 
List<string> ListDemo()
{
    List<string> Players = new List<string>();

    string Name = null;
    while (Name != "")
    {
        Name = GetPlayerName();
        if (Name != "")
            Players.Add(Name);
    }

    Console.WriteLine($"Nb d'éléments dans le tableau = {Players.Count()}");


    return Players;
}

void ShowPlayerList(List<string> listPlayer)
{
    Console.WriteLine($"\nListe des {listPlayer.Count} joueurs");

    foreach (string Name in listPlayer)
        Console.WriteLine(Name);

}

string GetPlayerName()
{  
   
    Console.Write($"Joueur {PlayerNumber + 1}, entre ton nom (laisser vide pour arrêter) : ");
    string Name = Console.ReadLine();
    PlayerNumber++;
    return Name;
}

