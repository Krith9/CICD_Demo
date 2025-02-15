using System.ComponentModel;
using CICD_Core;

Console.WriteLine("Enter your first number:");
int a, b;
while (true)
{
    string? s = Console.ReadLine();

    if (!int.TryParse(s, out a))
    {
        Console.WriteLine("Error: please enter a valid integer");
    }
    else
    {
        break;
    }
}

Console.WriteLine("Enter your second number:");
while (true)
{
    string? s = Console.ReadLine();
    if (!int.TryParse(s, out b))
    {
        Console.WriteLine("Error: please enter an integer");
    }
    else
    {
        break;
    }
}

double res = Calculator.Divide(a, b);
Console.WriteLine($"{a} / {b} = {res}");
