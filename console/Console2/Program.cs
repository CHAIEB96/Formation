// See https://aka.ms/new-console-template for more information

//declaration variable 

using System.Net.Cache;

string? Name = "";
int BirthYear = 0 ;
int CurrentYear = DateTime.Now.Year;

//start program 

Console.WriteLine("programme de calcule de l'age ");

//ask user input 
while (Name == ""  )
{
    Console.WriteLine($" Entre ton Nom  :");
    Name = Console.ReadLine();
    if (Name == "")
    {
        Console.WriteLine("tu dois entrer ton nom!!!!!");

    }
    if (int.TryParse(Name, out int Numbre))
    {
        Console.WriteLine("tu entrer un nom pas un nombre ");
        Name = "";

    }
}       


    while (BirthYear <= 1800 || BirthYear >= CurrentYear)
    {
        Console.WriteLine($" Entre ton age  :");
    //BirthYear = int.Parse(Console.ReadLine());
    bool isNumber = (int.TryParse(Console.ReadLine(), out BirthYear));
        if (!isNumber)
    
        Console.WriteLine("entrer un nombre !!!! ");
    
      else {
            if (BirthYear < 1800)
            {
                Console.WriteLine("entre une année supérieur a 1800");
            }
            else if (BirthYear > CurrentYear)
            {
                Console.WriteLine($" \n entre une année inférieur à {CurrentYear}");
            }
    }
 
}

//print result 
int Age = CurrentYear - BirthYear;
Console.WriteLine($" Bonjour { Name} ,tu as {Age} ans ");


