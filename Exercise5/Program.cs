using System;

Console.WriteLine("GENERATE MULTIPLICATION TABLE");
Console.Write("Enter Max Row: ");
int maxRows = int.Parse(Console.ReadLine());
Console.Write("Enter Max Column: ");
int maxCols = int.Parse(Console.ReadLine());

MakeSeparator();
int[,] mainTable = new int[maxRows, maxCols];
GenerateTable(mainTable);
RefreshTable(mainTable);

while (true)
{
    Console.Write("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    Console.Write("Do you want to change a number in any coordinate? (y/n): ");
    string choice = Console.ReadLine();

    if (choice == "y" || choice == "Y")
    {
        Console.Write("Enter coordinate X: ");
        int x_Coordinate = int.Parse(Console.ReadLine());
        Console.Write("Enter coordinate Y: ");
        int y_Coordinate = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        int newValue = int.Parse(Console.ReadLine());

        MakeSeparator();
        mainTable[x_Coordinate-1, y_Coordinate-1] = newValue;
        RefreshTable(mainTable);
    }
    else
    {
        Console.Write("Please enter any key to exit... ");
        Console.ReadKey();
        Console.Clear();
        break;
    }
}

static int[,] GenerateTable(int[,] table)
{
    for (int x = 0; x < table.GetLength(0); x++)
    {
        for (int y = 0; y < table.GetLength(1); y++)
        {
            table[x, y] = (x + 1) * (y + 1);
        }
    }
    return table;
}

static void RefreshTable(int[,] table)
{
    for (int x = 0; x < table.GetLength(0); x++)
    {
        for (int y = 0; y < table.GetLength(1); y++)
        {
            Console.Write(table[x, y] + "\t");
        }
        Console.WriteLine();
    }
}

static void MakeSeparator()
{
    for (int col = 1; col <= 100; col++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
}