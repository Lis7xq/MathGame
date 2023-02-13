using MathGame;
using System;
using static System.Formats.Asn1.AsnWriter;

var Menu = new Menu();

var date = DateTime.UtcNow;

var games = new List<string>();

string name = GetName();

Menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Hello, what is your name?");

    var name = Console.ReadLine();

    while (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Name can't be empty");
        name = Console.ReadLine();
    }

    return name;
}
