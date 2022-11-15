// See https://aka.ms/new-console-template for more information
string FirstName = "Rania";
int Age = 25;
Console.WriteLine($"je m'appelle{FirstName},j'ai {Age} ans ");

for(int i = 0; i < 11; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}est un nombre paire");
    }
    else if (i % 2 != 0)
    {
        Console.WriteLine($"{i} est un nombre impaire");
    }

      
    //Console.WriteLine(i);
}


