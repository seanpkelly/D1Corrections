using System;
using System.Text.RegularExpressions;

namespace D1Corrections

    {
        internal class Program
        {
            private static string VacationType;

            private static void Main(string[] args)
            {

                string VacationType;
                int GroupSize;
                string Destination;
                string TravelSuggestion;
                string Result;

                Console.WriteLine("Hello Travellers!");


                string testString;
                Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous? - ");
                VacationType = Console.ReadLine();
                Console.WriteLine("You entered '{0}'", VacationType);



                Console.Write("How many people will be in your party?: ");

                string input = Console.ReadLine();

                // ToInt32 can throw FormatException or OverflowException.
                try
                {

                    GroupSize = Convert.ToInt32(input);
                    if (GroupSize < Int32.MaxValue)
                    {
                        Console.WriteLine("You will be travelling in a party of {0} people", GroupSize);
                    }
                    else
                    {
                        Console.WriteLine("numVal cannot be incremented beyond its current value");
                    }
                }
                catch { }



                if (VacationType == "musical")
                {
                    Destination = "New Orleans";
                    //  Console.WriteLine("You will be travelling to New Orleans", VacationType);
                }

                else if (VacationType == "tropical")
                {
                    Destination = "Beach vacation in Mexico";
                    // Console.WriteLine("You will be experiencing a beach vacation in Mexico", VacationType);
                }

                else
                {
                    Destination = "Whitewater rafting the Grand Canyon";
                    // Console.WriteLine("You will be travelling to the Grand Canyon to whitewater raft", VacationType);
                }



            GroupSize = Convert.ToInt32(input);
            if (GroupSize <=2)
            {
                TravelSuggestion = "first class";
                //  Console.WriteLine("You will be travelling first class", TravelSuggestion);
            }

            else if (GroupSize >=3 && GroupSize <=5)
            {
                TravelSuggestion = "helicopter";
                // Console.WriteLine("You will be travelling via helicopter", TravelSuggestion);
            }

            else
            {
                TravelSuggestion = "charter flight";
                // Console.WriteLine("You will be travelling in a chartered flight, wow, congrats", TravelSuggestion);
            }



            Result = ($"You should travel to  {Destination} via  {TravelSuggestion}");
                Console.WriteLine(Result);
                Console.ReadLine();














            }



            //Console.Write("How many people are in your party? ");
            //Convert.ToInt32(Console.ReadLine());



        }
    }




