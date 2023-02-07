using System;
using static System.Formats.Asn1.AsnWriter;

var date = DateTime.UtcNow;

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Hello, what is your name?");

    var name = Console.ReadLine();

    return name;
}

void Menu(string name)
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
        Q - Quit the program");
        Console.WriteLine("---------------------------------------------");

        var gameMode = Console.ReadLine();

        switch (gameMode.Trim().ToLower())
        {
            case "a":
                AdditionGame("Addition selected");
                break;
            case "s":
                SubtractionGame("Subtraction selected");
                break;
            case "m":
                MultiplicationGame("Multiplication selected");
                break;
            case "d":
                DivisionGame("Division selected");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                isGameOn= false;   
                break;
            default:
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                break;
        }
    } while (isGameOn);

    

}

void AdditionGame(string message)
{
    Console.WriteLine("How many tries do you want to have ?");
    int tries = Convert.ToInt32(Console.ReadLine());

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;

    Console.Clear();

    for (int i = 0; i < tries; i++)
    {

        firstNumber= random.Next(1,9);
        secondNumber= random.Next(1,9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");

        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            score++;
            Console.WriteLine($"Correct!");
           
        }
        else
        {
            Console.WriteLine($"Incorrect!");
        }

        if(i == tries-1)
        {
            Console.WriteLine($"Game over, your score is {score}\nPress any key to continue");
        }
        Console.ReadLine();
    }

}

void SubtractionGame(string message)
{
    Console.WriteLine("How many tries do you want to have ?");
    int tries = Convert.ToInt32(Console.ReadLine());

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;

    Console.Clear();

    for (int i = 0; i < tries; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");

        var result = Console.ReadLine();

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
            Console.WriteLine($"Game over, your score is {score} \nPress any key to continue");
            Console.ReadLine();
        }
    }
}

void MultiplicationGame(string message)
{
    Console.WriteLine("How many tries do you want to have ?");
    int tries = Convert.ToInt32(Console.ReadLine());

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;

    Console.Clear();

    for (int i = 0; i < tries; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");

        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
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
            Console.WriteLine($"Game over, your score is {score} \nPress any key to continue");
            Console.ReadLine();
        }
    }
}

void DivisionGame(string message)
{
    var score = 0;

     Console.WriteLine("How many tries do you want to have ?");
     int tries = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    for (int i = 0; i < tries; i++)
    {
        var divisionNumbers = GetDivisionGame();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber}/{secondNumber}");
        var result = Console.ReadLine();

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
            Console.WriteLine($"Game over, your score is {score}  \nPress any key to continue");
            Console.ReadLine();
        }
    }


}

int[] GetDivisionGame()
{
    
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);

    var result = new int[2];

    

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1,99);
        secondNumber = random.Next(1,99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}