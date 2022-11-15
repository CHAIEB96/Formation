
Console.WriteLine("*******FIZZBUZZ********");

Console.WriteLine("donner le nombre de jouere");
int numbrePlayer = int.Parse(Console.ReadLine());
List<string> Players = new List<string>();
for (int i = 1; i <= numbrePlayer; i++)
{
    Console.Write($"Joueur {i }, entre ton nom : ");
    string Name = Console.ReadLine();
    Players.Add(Name);
 
}
for (int j = 1; j < 100; j++)
{
    Console.Write($"entrer un nombre : ");
    string numbre = Console.ReadLine();
    List<string> listNumber = new List<string>();
    List<string> ListFiZZBuzz = FizzBuzz();
    while (numbre != "")
    { 
        if (numbre != ListFiZZBuzz[j])
        {
            Console.WriteLine("tu as perdu");

        }
        else
            Console.WriteLine("tu as gagné");
    }
}



static List<string> FizzBuzz()
{
    var integerList = new List<string>();
    for (var i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
            integerList.Add(i.ToString());
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
            integerList.Add(i.ToString());
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
            integerList.Add(i.ToString());
        }
        else
        {
            Console.WriteLine(i);
            integerList.Add(i.ToString());
        }

    }
    return integerList;
}



