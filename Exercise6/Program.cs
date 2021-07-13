using System;

Console.Clear();
Console.WriteLine("GENERATE MULTIPLICATION TABLE");
int maxRow = ReadIntInput("Enter Max Row: ");
int maxCol = ReadIntInput("Enter Max Column: ");

MultiplicationTableGenerator multiplicationTable1 = new(maxRow, maxCol);
bool[,] modifiedTable = multiplicationTable1.ModifiedTable;
int[,] table = multiplicationTable1.Table;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("GENERATED TABLE");
Console.ResetColor();
Console.Write("-------------------------------------------------------------------------------------------------\n");
DisplayTableValue(table);
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
        int xCoordinate = ReadIntInput("Enter coordinate X: ") - 1;
        int yCoordinate = ReadIntInput("Enter coordinate Y: ") - 1;
        int newValue = ReadIntInput("Enter new value: ");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nNEWLY EDITED TABLE");
        Console.ResetColor();

        Console.Write("-------------------------------------------------------------------------------------------------\n");
        ChangeTableValue(xCoordinate, yCoordinate, newValue);
        DisplayTableValue(table);
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
    int output;
    bool reEnter = false;
    Console.Write(request);

    while (true)
    {
        if (reEnter == true)
        {
            Console.Write(request);
        }

        string input = Console.ReadLine();
        bool result = int.TryParse(input, out output);

        if (result == true || result == false)
        {
            if (result == true)
            {
                if (output <= 0)
                {
                    reEnter = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input! Please enter again.");
                    Console.ResetColor();
                    continue;
                }
            }
            if (result == false)
            {
                reEnter = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter again.");
                Console.ResetColor();
                continue;
            }
        }
        break;
    }
    return output;
}

void DisplayTableValue(int[,] table)
{
    for (int x = 0; x < table.GetLength(0); x++)
    {
        for (int y = 0; y < table.GetLength(1); y++)
        {
            if (modifiedTable[x, y])
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

void ChangeTableValue(int xCoordinate, int yCoordinate, int newValue)
{
    table[xCoordinate, yCoordinate] = newValue;
    modifiedTable[xCoordinate, yCoordinate] = true;
}