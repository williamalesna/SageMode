using System;

while (true)
{
    Console.Clear();
    Console.ResetColor();
    int a, b, input, sum, prod, diff = 0;
    double quot;
    Console.WriteLine("1.)Addition");
    Console.WriteLine("2.)Subtraction");
    Console.WriteLine("3.)Multiplication");
    Console.WriteLine("4.)Division");
    Console.Write("Choose a number from (1 - 4): ");
    input = int.Parse(Console.ReadLine());

    if (input == 1)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("You have chosen Addition");
        Console.Write("Enter First Number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        b = int.Parse(Console.ReadLine());
        sum = a + b;
        Console.WriteLine("The sum is: " + sum);
    }
    if (input == 2)
    {   
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You have chosen Subtraction");
        Console.Write("Enter First Number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        b = int.Parse(Console.ReadLine());
        diff = a - b;
        Console.WriteLine("The difference is: " + diff);
    }
    if (input == 3)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("You have chosen Multiplication");
        Console.Write("Enter First Number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        b = int.Parse(Console.ReadLine());
        prod = a * b;
        Console.WriteLine("The product is: " + prod);
    }
    if (input == 4)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("You have chosen Division");
        Console.Write("Enter First Number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        b = int.Parse(Console.ReadLine());
        quot = ((double)a / (double)b);
        Console.WriteLine("The quotient is: " + quot);
    }
    if (input >= 5 || input <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error Input! Press any key to exit.");
        Console.ReadKey();
        break;
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}


