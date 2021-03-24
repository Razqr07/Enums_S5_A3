using System;

namespace Enums_S5_A3
{
    class Program
    {
        #region DaysOfTheWeek
        enum Weekdays
        {
            Maandag,
            Dinsdag,
            Woensdag,
            Donderdag,
            Vrijdag,
            Zaterdag,
            Zondag
        }

        enum Directions
        {
            North,
            East,
            South,
            West,
            Stay
        }
        #endregion


        static void Main(string[] args)
        {
            #region Part1
            Weekdays today;
            today = Weekdays.Woensdag;

            switch (today)
            {
                case Weekdays.Maandag:
                    Console.WriteLine("Vandaag is het Maandag!");
                    break;
                case Weekdays.Dinsdag:
                    Console.WriteLine("Vandaag is het Dinsdag!");
                    break;
                case Weekdays.Woensdag:
                    Console.WriteLine("Vandaag is het Woensdag!");
                    break;
                case Weekdays.Donderdag:
                    Console.WriteLine("Vandaag is het Donderdag!");
                    break;
                case Weekdays.Vrijdag:
                    Console.WriteLine("Vandaag is het Vrijdag!");
                    break;
                case Weekdays.Zaterdag:
                    Console.WriteLine("Vandaag is het Zaterdag!");
                    break;
                case Weekdays.Zondag:
                    Console.WriteLine("Vandaag is het Zondag!");
                    break;
                default:
                    break;
            }
                    #endregion
                    #region Directions

                    #region Variables
                    string input;
                    int choice;
                    #endregion

                    Directions playerDirection;
                    Console.WriteLine("Choose a direction. You can choose from: 1 North,  2 East, 3 South, 4 West and 5 Stay");
                    input = Console.ReadLine();

                    int.TryParse(input, out choice);

                    ShowMenu();

                    void ShowMenu()
                    {
                        switch (choice)
                        {
                            case 1:
                        Console.WriteLine("You chose North!");
                                playerDirection = Directions.North;
                                break;
                            case 2:
                        Console.WriteLine("You chose East!");
                                playerDirection = Directions.East;
                                break;
                            case 3:
                        Console.WriteLine("You chose South!");
                                playerDirection = Directions.South;
                                break;
                            case 4:
                        Console.WriteLine("You chose West!");
                                playerDirection = Directions.West;
                                break;
                            case 5:
                        Console.WriteLine("You chose Stay!");
                                playerDirection = Directions.Stay;
                                break;

                            default:
                                break;
                        }
                    }

                    #endregion
            
        }
    }
}
