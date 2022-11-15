using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ExempleClasse
{
    public class Program
    {
        #region "variable"
        const int MinimumNumberOfRacers = 2;
        const int MaximumNumberOfRacers = 10;
        const int MinimumRaceLength = 10;
        const int MaximumRaceLength = 1000;
        static int RaceLength = 0;
        const int SpeedRandomFactor = 10;
        static Random rnd = new Random();
        #endregion

        static List<Vehicle> Vehicles = new List<Vehicle>();
        static List<Vehicle> Racers = new List<Vehicle>();

        public static void Main()
        {
            Console.WriteLine("\n *********course de véhicules***********");
            InitializeData();
            PrepareRace();
            ShowRacers();

        }
         public static void InitializeData()
        {
            Vehicles.Add(new Vehicle("Bentley", "Luxe", ConsoleColor.Gray, 200));
            Vehicles.Add(new Vehicle("Ferrari", "Testarrossa", ConsoleColor.Red, 300));
            Vehicles.Add(new Vehicle("Lamborghini", "Countach", ConsoleColor.Yellow, 280));
            Vehicles.Add(new Vehicle("Ferrari", "F40", ConsoleColor.Magenta, 330));
            Vehicles.Add(new Vehicle("Tesla", "Model S", ConsoleColor.Blue, 200));
            Vehicles.Add(new Vehicle("Porsche", "911 Carrera GT", ConsoleColor.Green, 250));
            Vehicles.Add(new Vehicle("BMW", "M3", ConsoleColor.DarkBlue, 230));
            Vehicles.Add(new Vehicle("Ford", "GT 40", ConsoleColor.Red, 240));
            Vehicles.Add(new Vehicle("Lada", "Minabilis", ConsoleColor.White, 190));
            Vehicles.Add(new Vehicle("Peugeot", "208 GT", ConsoleColor.Cyan, 180));
            Vehicles.Add(new Vehicle("Bugatti", "Chiron", ConsoleColor.DarkYellow, 260));
            Vehicles.Add(new Vehicle("Mercedes", "AMG", ConsoleColor.DarkMagenta, 240));
        }
         public static void PrepareRace()
         {
            //demande le nombre de participant 
            int NumberOfRacers = 0;
            Console.WriteLine("\n combien de véhicules(2 à 10) participent à la course ???");
            bool IsNumber = int.TryParse(Console.ReadLine(), out NumberOfRacers);
            do
            {
                if(IsNumber&& (NumberOfRacers < MinimumNumberOfRacers || NumberOfRacers > MaximumNumberOfRacers))
                {
                    Console.WriteLine($"il faut entrée un nombre entre {MinimumNumberOfRacers} et {MaximumNumberOfRacers}");
                }else if (!IsNumber)
                {
                    Console.WriteLine("il faut entrer un nombre ");
                }
            }while (NumberOfRacers < MinimumNumberOfRacers || NumberOfRacers > MaximumNumberOfRacers);
            // tirer les participants et ajouter à la liste Racers
            for (int nb = 0; nb <= NumberOfRacers; nb++)
            {
                Vehicle Racer = Vehicles[rnd.Next(0, Vehicles.Count)];
                Racers.Add(new Vehicle(Racer));
            }
            // demander la longueur de la course
            
            do
            {
                Console.WriteLine($"\nEntrez une longueur de course (entre {MinimumRaceLength} et {MaximumRaceLength}) : ");
                bool IsNumb = int.TryParse(Console.ReadLine(), out RaceLength);
                if (IsNumb && (RaceLength < MinimumRaceLength || RaceLength > MaximumRaceLength))
                {
                    Console.WriteLine($"entre une distance entre {MinimumRaceLength}et {MaximumRaceLength}");
                }
                else if (!IsNumb)
                {
                    Console.WriteLine("entrée un nomebre ");
                }
                
             } while ((RaceLength < MinimumRaceLength) || (RaceLength > MaximumRaceLength));
              RaceLength *= 1000;
         }
         public static void ShowRacers(int Round = 0)
         {
            string Message;
            if(Round>0)
                Message= $"\nEtat de la course à la fin de l'étape {Round}";
            else 
                Message= $"\nListe des {Racers.Count} participants :";
            Console.WriteLine(Message);
            foreach(Vehicle race in Racers)
            {
                race.DisplayData(Round > 0);
            }

        }
        public static void RaceInProgress() {
            Console.WriteLine($"\nLes {Racers.Count} concurrents sont sur la ligne de départ... ");
            int Round = 0;
            int ArrivedRacers = 0;
            do
            {
                Round++;
                ShowRacers(Round);
                foreach (Vehicle Racer in Racers)
                {
                    if (Racer.DistanceFromOrigin < RaceLength)
                    {
                        if (Racer.Move(rnd, SpeedRandomFactor, RaceLength))
                            ArrivedRacers++;
                    }
                }


            } while (ArrivedRacers < Racers.Count);
        }
        public static void RaceFinished() {
            Console.WriteLine("Tous les véhicules ont franchi la ligne d'arrivée !");
            Console.WriteLine("Voici le podium :");
            Racers = Racers.OrderBy(v => v.PodiumNumber).ToList();
            foreach(Vehicle race in Racers)
            {
                race.DisplayData(true, true);
            }
          
        }
    }
}

