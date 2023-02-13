
namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            bool isGameOn = true;

            do
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Hello {name}. It's {date}. Time for a small challenge");
                Console.WriteLine(@$"In which game mode would you like to challenge yourself?:
        A - Addition 
        S - Subtraction 
        M - Multiplication 
        D - Division
        R - Randome game
        Q - Quit the program
        V - View game history");
                Console.WriteLine("---------------------------------------------");

                var gameMode = Console.ReadLine();

                switch (gameMode.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition selected");
                       
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction selected");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication selected");
                        break;
                    case "d":
                        engine.DivisionGame("Division selected");
                        break;
                    case "r":
                        engine.RandomGame("Division selected");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        break;
                }
            } while (isGameOn);



        }

    }
}
