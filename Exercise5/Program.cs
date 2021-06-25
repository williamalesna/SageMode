using System;

Console.WriteLine("GENERATE MULTIPLICATION TABLE");
string s_maxRows = "", s_maxCols = "", s_xCoordinate = "", s_yCoordinate = "", s_newValue = "";
int maxRows = 0, maxCols = 0, x_Coordinate = 0, y_Coordinate = 0, newValue = 0;



Console.Write("Enter Max Row: ");
s_maxRows = Console.ReadLine();
while(!int.TryParse(s_maxRows, out maxRows))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The input you entered is invalid!");
    Console.ResetColor();
    Console.Write("Enter Max Row: ");
    s_maxRows = Console.ReadLine();
}

Console.Write("Enter Max Column: ");
s_maxCols = Console.ReadLine();
while(!int.TryParse(s_maxCols, out maxCols))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The input you entered is invalid!");
    Console.ResetColor();
    Console.Write("Enter Max Column: ");
    s_maxCols = Console.ReadLine();
}

MakeSeparator();
int[,] mainTable = new int[maxRows, maxCols];
GenerateTable(mainTable);
RefreshTable(mainTable);
MakeSeparator();

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
        s_xCoordinate = Console.ReadLine();
        while(!int.TryParse(s_xCoordinate, out x_Coordinate))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The input you entered is invalid!");
            Console.ResetColor();
            Console.Write("Enter coordinate X: ");
            s_xCoordinate = Console.ReadLine();
        }

        Console.Write("Enter coordinate Y: ");
        s_yCoordinate = Console.ReadLine();
        while(!int.TryParse(s_yCoordinate, out y_Coordinate))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The input you entered is invalid!");
            Console.ResetColor();
            Console.Write("Enter coordinate Y: ");
            s_yCoordinate = Console.ReadLine();
        }

        Console.Write("Enter value: ");
        s_newValue = Console.ReadLine();
        while(!int.TryParse(s_newValue, out newValue))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The input you entered is invalid!");
            Console.ResetColor();
            Console.Write("Enter Value: ");
            s_newValue = Console.ReadLine();
        }


        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nNEWLY EDITED TABLE");
        Console.ResetColor();
        MakeSeparator();
        mainTable[y_Coordinate - 1, x_Coordinate - 1] = newValue;
        var newVal = mainTable[y_Coordinate - 1, x_Coordinate - 1];
        RefreshTable(mainTable, newVal);
        MakeSeparator();
        
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

static void RefreshTable(int[,] table, int newVal = 0)
{
    for (int x = 0; x < table.GetLength(0); x++)
    {
        for (int y = 0; y < table.GetLength(1); y++)
        {
            if(newVal == table[x,y])
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(table[x, y] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

static void MakeSeparator()
{
    for (int col = 1; col <= 100; col++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("-");
    }
    Console.ResetColor();
    Console.WriteLine();
}