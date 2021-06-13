using System;


while (true)
{
    Console.Clear();
    Console.Write("Enter a number: ");

    int input = int.Parse(Console.ReadLine());
    int sum = 0;

    if (input < 0)
    {
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        break;
    }

    for (int i = 1; i <= 9; i++)
    {
        sum = sum + input;
        Console.WriteLine(sum);
    }

    
    Console.Write("Press any key to continue...");
    Console.ReadKey();

    
}
