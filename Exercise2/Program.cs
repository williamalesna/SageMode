using System;

Console.Clear();
int a, b, input, sum, prod, diff, quot = 0;
Console.WriteLine("1.)Addition\n2.)Subtraction\n3.)Multiplication\n4.)Division");
Console.Write("Choose a number from (1 - 4): ");
input = int.Parse(Console.ReadLine());

switch (input)
{
    case 1:
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("You have chosen Addition");
        Console.Write("Enter First Number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        b = int.Parse(Console.ReadLine());
        sum = a + b;
        Console.WriteLine("The sum is: " + sum);
        break;

    case 2:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You have chosen Subtraction");
        Console.Write("Enter First Number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        b = int.Parse(Console.ReadLine());
        diff = a - b;
        Console.WriteLine("The difference is: " + diff);
        break;

    case 3:
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("You have chosen Multiplication");
        Console.Write("Enter First Number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        b = int.Parse(Console.ReadLine());
        prod = a * b;
        Console.WriteLine("The product is: " + prod);
        break;

    case 4:
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("You have chosen Division");
        Console.Write("Enter First Number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        b = int.Parse(Console.ReadLine());
        quot = a / b;
        Console.WriteLine("The quotient is: " + quot);
        break;

    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The input you entered is invalid! Please try again.");
        Console.Beep();
        break;
}



