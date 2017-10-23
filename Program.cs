using System;

namespace _10011845_assessment3_question02
{
    class Falcon
    {
        private string _FalconName;
        private string _Species;
        private string _Sex;
        private string _Weight;
        private string _BandNumber;

        public string FalconName
        {
            set
            {
                _FalconName = value;
            }
        }

        public string Species
        {
            set
            {
                _Species = value;
            }
        }

        public string Sex
        {
            set
            {
                _Sex = value;
            }
        }

        public string Weight
        {
            set
            {
                _Weight = value;
            }
        }
        public string BandNumber
        {
            set
            {
                _BandNumber = value;
            }
        }


        public Falcon(string _FalconName, string _Species, string _Sex, string _Weight, string _BandNumber)
        {
            FalconName = _FalconName;
            Species = _Species;
            Sex = _Sex;
            Weight = _Weight;
            BandNumber = _BandNumber;
        }



        public string DisplayFalcon()
        {
            var showfalcon = "FALCON DATA OUTPUT\n\n";
            showfalcon += $"Name of Falcon: {_FalconName}\n";
            showfalcon += $"Type of Falcon: {_Species}\n";
            showfalcon += $"Gender of Falcon: {_Sex}\n";
            showfalcon += $"Weight of Falcon: {_Weight}\n";
            showfalcon += $"Falcon's Band Number: {_BandNumber}\n";

            return showfalcon;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Falcon Database");
            Console.WriteLine("------------------------------------------");



            var Falcon1 = new Falcon("", "", "", "", "");
            Console.WriteLine("Enter Falcon name: ");
            Falcon1.FalconName = Console.ReadLine();
            Console.WriteLine("Enter Falcon Species: ");
            Falcon1.Species = Console.ReadLine();
            Console.WriteLine("Enter Falcon Sex: ");
            Falcon1.Sex = Console.ReadLine();
            Console.WriteLine("Enter Weight of Falcon: ");
            Falcon1.Weight = Console.ReadLine();
            Console.WriteLine("Enter Band Number of Falcon");
            Falcon1.BandNumber = Console.ReadLine();
            Console.WriteLine("------------------------------------------");

            Console.WriteLine(Falcon1.DisplayFalcon());



            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("**************PROGRAM END***************");
            Console.WriteLine("Please Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
