using System;

Console.Clear();
Console.WriteLine("GENERATE MULTIPLICATION TABLE");
var maxRow = ReadIntInput("Enter Max Row: ");
var maxCol = ReadIntInput("Enter Max Column: ");

var multiplicationTable1 = new MultiplicationTable(maxRow, maxCol);

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
    var choice = Console.ReadLine().ToLower();

    if (choice == "y")
    {
        var xCoord = ReadIntInput("Enter coordinate X: ") - 1;
        var yCoord = ReadIntInput("Enter coordinate Y: ") - 1;
        var newValue = ReadIntInput("Enter new value: ");

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

        var input = Console.ReadLine();
        var result = int.TryParse(input, out var output);

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

    for (var x = 0; x < table.GetLength(0); x++)
    {
        for (var y = 0; y < table.GetLength(1); y++)
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