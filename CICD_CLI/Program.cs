using System.ComponentModel;
using CICD_Core;

Console.WriteLine("Enter first number:");
int a, b;
while (true)
{
    string? s = Console.ReadLine();

    if (!int.TryParse(s, out a))
    {
        Console.WriteLine("Error: please enter the valid integer");
    }
    else
    {
        break;
    }
}

Console.WriteLine("Enter second number:");
while (true)
{
    string? s = Console.ReadLine();
    if (!int.TryParse(s, out b))
    {
        Console.WriteLine("Error: please enter integer");
    }
    else
    {
        break;
    }
}

double res = Calculator.Divide(a, b);
Console.WriteLine($"{a} / {b} = {res}");
