


using System.Collections.Concurrent;

Console.Write("Enter the first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Please select an operation:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
int choice = int.Parse(Console.ReadLine());


switch (choice)
{
    case 1:
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;

    case 2:
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case 3:
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;

    case 4:
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by 0");
        }
        else 
            Console.WriteLine($"{num1} / {num2} = {Math.Round((double)num1 / (double)num2, 2)}");
        break;
    default:
        Console.WriteLine("invalid choice");
        break;
        
}











