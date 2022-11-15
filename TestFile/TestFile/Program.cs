using System.Text;
using TestFile;

public class Program
{
   public static  string Filepath = "C:\\formation\\TestFile\\teste.csv";
    public static  List<Person> Persons = new List<Person>();
    public static List<Person> Students = new List<Person>();

    public static void Main()
    {
        InitializeData();
        WriteFile(Filepath, Persons);
        redFile(Filepath);
        ListData(Students);

    }
    public static void WriteFile(string Filepath,List<Person> Data)
    {
       using  StreamWriter? mystream = new StreamWriter(Filepath,false,Encoding.UTF8);
        foreach(Person currentperson in Data)
        {
            mystream.WriteLine($"{currentperson.LastName} ; "   
                 +$"{currentperson.FirstName}; " 
                +$"{currentperson.sexe} ;"
                + $"{currentperson.BirthYear};");
        }
     
     

    }
    public static void redFile(string filepath)
    {
        Console.WriteLine("lecture de fichier");
        using StreamReader? mystream = new StreamReader(filepath);
        string Result= mystream.ReadLine();

        while (Result != null)
        {
            string[] studentData = Result.Split(";");
            Students.Add(new Person(studentData[0],
                studentData[1],
                studentData[2],
                Convert.ToInt32(studentData[3])
                ));
            Console.WriteLine(Result);
            Result = mystream.ReadLine();
        }
    
     
    }
    private static void ListData(List<Person> listData)
    {
        foreach(Person item in listData)
        {
            Console.WriteLine($"{item.LastName}" +$"{item.FirstName}"+$"{item.sexe}"+$"{item.BirthYear}");
        }
    }
    private static void InitializeData()
    {
        Persons.Add(new Person("chaieb","Rania","femme",1996));
        Persons.Add(new Person("chaieb11", "Rania11", "femme", 1996));
        Persons.Add(new Person("chaieb22", "Rania22", "femme", 1997));
        Persons.Add(new Person("chaieb33", "Rania33", "femme", 1998));



    }
}