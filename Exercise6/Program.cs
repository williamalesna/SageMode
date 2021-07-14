using System;

Console.Clear();
Console.WriteLine("GENERATE MULTIPLICATION TABLE");
int maxRow = ReadIntInput("Enter Max Row: ");
int maxCol = ReadIntInput("Enter Max Column: ");

MultiplicationTable multiplicationTable1 = new(maxRow, maxCol);

Console.Clear();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("GENERATED TABLE");
Console.ResetColor();
Console.Write("-------------------------------------------------------------------------------------------------\n");
DisplayTable();
Console.Write("-------------------------------------------------------------------------------------------------\n");

while (true)
{
    Console.Write("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    Console.Write("Do you want to change a number in any coordinate? (y/n): ");
    string choice = Console.ReadLine().ToLower();

    if (choice == "y")
    {
        int xCoord = ReadIntInput("Enter coordinate X: ") - 1;
        int yCoord = ReadIntInput("Enter coordinate Y: ") - 1;
        int newValue = ReadIntInput("Enter new value: ");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nNEWLY EDITED TABLE");
        Console.ResetColor();

        Console.Write("-------------------------------------------------------------------------------------------------\n");
        multiplicationTable1.SetValueInCoordinate(yCoord, xCoord, newValue);
        DisplayTable();
        Console.Write("-------------------------------------------------------------------------------------------------\n");
    }
    else if (choice == "n")
    {
        Console.Write("Press any key to exit... ");
        Console.ReadKey();
        Console.Clear();
        break;
    }
    else
    {
        continue;
    }
}

int ReadIntInput(string request)
{
    while (true)
    {
        Console.Write(request);

        string input = Console.ReadLine();
        bool result = int.TryParse(input, out int output);

        if (!result || output <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input! Please enter again.");
            Console.ResetColor();
            continue;
        }
        return output;
    }
}

void DisplayTable()
{
    var table = multiplicationTable1.Table;

    for (int x = 0; x < table.GetLength(0); x++)
    {
        for (int y = 0; y < table.GetLength(1); y++)
        {
            if (multiplicationTable1.IsCoordinatesModified(x, y))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(table[x, y] + "\t");
                Console.ResetColor();
            }
            else
            {
                Console.Write(table[x, y] + "\t");
            }
        }
        Console.WriteLine();
    }
}