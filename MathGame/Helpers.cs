

using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>();

        internal static void GetGames()
        {
            

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts - {game.Difficulty}");
            }
            Console.WriteLine("------------------\n");
            Console.WriteLine("Press any key");
            var output = Console.ReadLine();

            

            Console.Clear();
        }

        internal static void AddToHistory(int gameScore, GameType gameType, int dif)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
                Difficulty = dif,
               
            });
        }



        internal static int[] GetDivisionGame(int number)
        {

            var random = new Random();
            var firstNumber = random.Next(0, number);
            var secondNumber = random.Next(0, number);

            var result = new int[2];



            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, number);
                secondNumber = random.Next(1, number);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
    }

    
}
