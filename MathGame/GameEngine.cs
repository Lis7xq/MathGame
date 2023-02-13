
using MathGame.Models;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;


namespace MathGame
{
    internal class GameEngine
    {
        internal static int Difficulty(string dif)
        {
            int numb = 0;
            if (dif.Trim().ToLower() == "a")
            {
                numb = 9;

                return numb;

            }
            else if (dif.Trim().ToLower() == "b")
            {
                numb = 99;
                return numb;
            }
            else if (dif.Trim().ToLower() == "c")
            {
                numb = 999;
                return numb;
            }
            return numb;
        }

        internal void AdditionGame(string message)
        {

            var random = new Random();

            int score = 0;
            int firstNumber;
            int secondNumber;

            Console.WriteLine("How many tries do you want to have ?");
            var tries = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("What difficulty you would like to have ?\nA-Easy(1-9)\nB-Medium(1-99)\nC-Hard(1-999)");
            string level = Console.ReadLine();
            var d = Difficulty(level);

            Console.Clear();
           
            
            for (int i = 0; i < tries; i++)
            {
                var sw = new Stopwatch();
                sw.Start();

                firstNumber = random.Next(1, d);
                secondNumber = random.Next(1, d);


                Console.WriteLine($"{firstNumber} + {secondNumber}");

                

                var result = Console.ReadLine();

                

                while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                {
                    Console.WriteLine("Your answer needs to be an integer. Try again");
                    result = Console.ReadLine();
                }



                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    score++;
                    Console.WriteLine($"Correct!");

                }
                else
                {
                    Console.WriteLine($"Incorrect!");
                }

                if (i == tries - 1)
                {
                    Console.WriteLine($"Game over, your score is {score}\nPress any key to continue\nDifficulty - {d}\nTime {sw.Elapsed}");
                }
                Console.ReadLine();
                sw.Stop();
                Console.Clear();
            }

            Helpers.AddToHistory(score, GameType.Addition, d);

           

        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine("How many tries do you want to have ?");
            int tries = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What difficulty you would like to have ?\nA-Easy(1-9)\nB-Medium(1-99)\nC-Hard(1-999)");
            string level = Console.ReadLine();
            var d = Difficulty(level);
            

            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            Console.Clear();

            for (int i = 0; i < tries; i++)
            {
                firstNumber = random.Next(1, d);
                secondNumber = random.Next(1, d);

                var sw = new Stopwatch();
                sw.Start();

                Console.WriteLine($"{firstNumber} - {secondNumber}");


                

                var result = Console.ReadLine();

                

                while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                {
                    Console.WriteLine("Your answer needs to be an integer. Try again");
                    result = Console.ReadLine();    
                }

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    score++;
                    Console.WriteLine($"Correct!");

                }
                else
                {
                    Console.WriteLine($"Incorrect!");
                }

                if (i == tries - 1)
                {
                    Console.WriteLine($"Game over, your score is {score} \nPress any key to continue\nDifficulty - {d}\nTime {sw.Elapsed}");
                    Console.ReadLine();
                    
                }
                sw.Stop();
                Console.Clear();
            }

            Helpers.AddToHistory(score, GameType.Subtraction, d);
        }

        internal void MultiplicationGame(string message)
        {
            Console.WriteLine("How many tries do you want to have ?");
            int tries = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What difficulty you would like to have ?\nA-Easy(1-9)\nB-Medium(1-99)\nC-Hard(1-999)");
            string level = Console.ReadLine();
            var d = Difficulty(level);

            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            Console.Clear();

            for (int i = 0; i < tries; i++)
            {
                firstNumber = random.Next(1, d);
                secondNumber = random.Next(1, d);


                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var sw = new Stopwatch();
                sw.Start();


                var result = Console.ReadLine();

                

                while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                {
                    Console.WriteLine("Your answer needs to be an integer. Try again");
                    result = Console.ReadLine();
                }

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    score++;
                    Console.WriteLine("Correct!");

                }

                else
                {
                    Console.WriteLine("Incorrect!");
                }

                if (i == tries - 1)
                {
                    Console.WriteLine($"Game over, your score is {score} \nPress any key to continue\nDifficulty - {d}\nTime {sw.Elapsed}");
                    Console.ReadLine();
                    
                }
                sw.Stop();
                Console.Clear();
            }

            Helpers.AddToHistory(score, GameType.Multiplication, d);
        }

        internal void DivisionGame(string message)
        {
            var score = 0;

            Console.WriteLine("How many tries do you want to have ?");
            int tries = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What difficulty you would like to have ?\nA-Easy(1-9)\nB-Medium(1-99)\nC-Hard(1-999)");
            string level = Console.ReadLine();
            var d = Difficulty(level);

            Console.Clear();

            for (int i = 0; i < tries; i++)
            {
                var divisionNumbers = Helpers.GetDivisionGame(d);
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber}/{secondNumber}");

                var sw = new Stopwatch();
                sw.Start();

                var result = Console.ReadLine();

               

                while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                {
                    Console.WriteLine("Your answer needs to be an integer. Try again");
                    result = Console.ReadLine();
                }

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    score++;
                    Console.WriteLine($"Correct!");

                }
                else
                {
                    Console.WriteLine($"Incorrect!");
                }

                if (i == tries - 1)
                {
                    Console.WriteLine($"Game over, your score is {score} \nPress any key to continue\nDifficulty - {d}\nTime {sw.Elapsed}");
                    Console.ReadLine();
                    
                }
                sw.Stop();
                Console.Clear();
            }
            Helpers.AddToHistory(score, GameType.Division, d);

        }


        
        internal void RandomGame(string message)
        {
            Console.WriteLine("How many tries do you want to have ?");
            int tries = Convert.ToInt32(Console.ReadLine());
            var sw = new Stopwatch();
            Console.WriteLine("What difficulty you would like to have ?\nA-Easy(1-9)\nB-Medium(1-99)\nC-Hard(1-999)");
            string level = Console.ReadLine();
            Console.Clear();
            var d = Difficulty(level);
            var score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < tries; i++)
            {
                var random = new Random();

                
                int modenumber;
                modenumber = random.Next(1, 5);

                if (modenumber == 1)
                {
                    sw.Start();
                    firstNumber = random.Next(1, d);
                    secondNumber = random.Next(1, d);


                    Console.WriteLine($"{firstNumber} + {secondNumber}");

                    var result = Console.ReadLine();

                    while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                    {
                        Console.WriteLine("Your answer needs to be an integer. Try again");
                        result = Console.ReadLine();
                    }
                    
                    if (int.Parse(result) == firstNumber + secondNumber)
                    {
                        score++;
                        Console.WriteLine($"Correct!");

                    }
                    else
                    {
                        Console.WriteLine($"Incorrect!");
                    }
                    
                    Console.ReadLine();
                    sw.Stop();
                    Helpers.AddToHistory(score, GameType.Addition, d);
                    Console.Clear();
                    
                }
                else if (modenumber == 2)
                {
                    
                        sw.Start();

                        firstNumber = random.Next(1, d);
                        secondNumber = random.Next(1, d);

                        Console.WriteLine($"{firstNumber} - {secondNumber}");

                        var result = Console.ReadLine();

                        while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                        {
                            Console.WriteLine("Your answer needs to be an integer. Try again");
                            result = Console.ReadLine();
                        }

                        if (int.Parse(result) == firstNumber - secondNumber)
                        {
                            score++;
                            Console.WriteLine($"Correct!");
                        }
                        else
                        {
                            Console.WriteLine($"Incorrect!");
                        }

                        
                        Console.ReadLine();
                        sw.Stop();
                    Helpers.AddToHistory(score, GameType.Subtraction, d);
                        Console.Clear();
                    
                }
                else if (modenumber == 3)
                {
                    firstNumber = random.Next(1, d);
                    secondNumber = random.Next(1, d);


                    Console.WriteLine($"{firstNumber} * {secondNumber}");
                   
                    sw.Start();


                    var result = Console.ReadLine();



                    while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                    {
                        Console.WriteLine("Your answer needs to be an integer. Try again");
                        result = Console.ReadLine();
                    }

                    if (int.Parse(result) == firstNumber * secondNumber)
                    {
                        score++;
                        Console.WriteLine($"Correct!");

                    }
                    else
                    {
                        Console.WriteLine($"Incorrect!");
                    }

                    
                    sw.Stop();
                    Helpers.AddToHistory(score, GameType.Multiplication, d);
                    Console.Clear();
                }
                else if (modenumber == 4)
                {
                    var divisionNumbers = Helpers.GetDivisionGame(d);
                     firstNumber = divisionNumbers[0];
                     secondNumber = divisionNumbers[1];

                    Console.WriteLine($"{firstNumber}/{secondNumber}");

                    sw.Start();

                    var result = Console.ReadLine();

                    while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                    {
                        Console.WriteLine("Your answer needs to be an integer. Try again");
                        result = Console.ReadLine();
                    }

                    if (int.Parse(result) == firstNumber / secondNumber)
                    {
                        score++;
                        Console.WriteLine($"Correct!");

                    }
                    else
                    {
                        Console.WriteLine($"Incorrect!");
                    }

                    
                    sw.Stop();
                    Helpers.AddToHistory(score, GameType.Division, d);
                    Console.Clear();
                }
                if (i == tries - 1)
                {
                    Console.WriteLine($"Game over, your score is {score}\nPress any key to continue\nDifficulty - {d}\nTime {sw.Elapsed}");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

        }
    }
}
