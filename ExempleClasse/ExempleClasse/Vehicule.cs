using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExempleClasse
{
    public class Vehicle
    {
        #region"Variable"
        int UniqueNumber = 0;
        static int NextPodiumNumber =0;

        #endregion
        #region "proprieté"
        public string Brand { get; set; }
        public string Model { get; set; }
        public ConsoleColor Color { get; set; }
        public int HorsPower { get; set; }
        public int DistanceFromOrigin { get; set; } = 0;
        public int? UniqueNumberInRace { get; set; }
        public int? PodiumNumber { get; set; }
        #endregion



        public Vehicle(string Brand, string Model, ConsoleColor Color, int HorsPower)
        {
            this.Brand = Brand;
            this.Model=Model;
            this.Color = Color;
            this.HorsPower = HorsPower;
        }

        public Vehicle(Vehicle InitialVehicle)
        {
            this.Brand = InitialVehicle.Brand;
            this.Model = InitialVehicle.Model;
            this.Color = InitialVehicle.Color;
            this.HorsPower = InitialVehicle.HorsPower;
            UniqueNumber++;
            this.UniqueNumberInRace = UniqueNumber;
        }

        public void DisplayData(bool ShowDistance = true,bool ShowPodiumNumber = false)
        {
            string DisplayString = $"Voiture numéro {UniqueNumberInRace} - {Brand} {Model} ({HorsPower}cv)";
            if (PodiumNumber == null)
            {
                Console.ForegroundColor = Color;
                if (ShowDistance)
                    DisplayString += $" a parcourue {DistanceFromOrigin / 1000}km";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = Color;
                DisplayString += " est arrivée !!!";
            }
            if (ShowPodiumNumber)
                DisplayString = $"{PodiumNumber} → " + DisplayString;
                Console.Write(DisplayString);
                Console.ResetColor();
                Console.Write("\n");

        }

        public bool Move(Random rnd, int RandomFactor,int RaceLength)
        {
            int RandomDistance = HorsPower * RandomFactor / 100;

            int RandomStep = rnd.Next(0, 2);
            int RandomMultiplicator = (RandomStep == 0 ? -1 : 1);
            //int RandomMultiplicator;
            //if (RandomStep == 0)
            //    RandomMultiplicator = -1;
            //else
            //    RandomMultiplicator = 1;

            DistanceFromOrigin += HorsPower + RandomMultiplicator * RandomDistance;

            // check if vehicle has arrived
            if (DistanceFromOrigin >= RaceLength)
            {
                NextPodiumNumber++;
                PodiumNumber = NextPodiumNumber;
            }

            return (PodiumNumber > 0);
        }


    }




}
