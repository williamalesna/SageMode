using System;

Console.Clear();
Console.WriteLine("GENERATE MULTIPLICATION TABLE");
Console.Write("Enter Max Row: ");
int maxRow = int.Parse(Console.ReadLine());
Console.Write("Enter Max Column: ");
int maxCol = int.Parse(Console.ReadLine());

Multiplication table1 = new Multiplication(maxRow, maxCol);

MakeSeparator();
table1.GenerateTable();
MakeSeparator();

while (true)
{
    Console.Write("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    Console.Write("Do you want to change a number in any coordinate? (y/n): ");
    string choice = Console.ReadLine();

    if (choice == "y" | choice == "Y")
    {
        Console.Write("Enter coordinate X: ");
        int xCoordinate = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter coordinate y: ");
        int yCoordinate = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter new value: ");
        int newValue = int.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nNEWLY EDITED TABLE");
        Console.ResetColor();

        MakeSeparator();
        table1.ChangeTableValue(xCoordinate, yCoordinate, newValue);
        MakeSeparator();
    }
    else
    {
        Console.Write("Press any key to exit... ");
        Console.ReadKey();
        Console.Clear();
        break;
    }
}

void MakeSeparator()
{
    for (int x = 0; x <= 100; x++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("-");
    }
    Console.ResetColor();
    Console.WriteLine();
}

