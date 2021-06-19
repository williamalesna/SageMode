using System;

static int[,] StoreTableValue(int rows, int cols)
{
    int[,] table = new int[rows, cols];

    int x = 0;
    int y = 0;

    for (x = 0; x < rows; x++)
    {
        for (y = 0; y < cols; y++)
        {
            table[x, y] = (x + 1) * (y + 1);
        }
    }
    return table;
}

static void AddNewTableValue(int[,] table, int xCoor, int yCoor, int newVal, int rows, int cols)
{
    int[,] newTable = table;
    newTable[xCoor, yCoor] = newVal;

    for (int j = 0; j < rows; j++)
    {
        for (int k = 0; k < cols; k++)
        {
            Console.Write(newTable[j, k] + "\t");
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

int maxRows, maxCols;
Console.WriteLine("GENERATE MULTIPLICATION TABLE");
Console.Write("Enter Max Row: ");
maxRows = int.Parse(Console.ReadLine());
Console.Write("Enter Max Column: ");
maxCols = int.Parse(Console.ReadLine());

MakeSeparator();

int[,] tableCopy = StoreTableValue(maxRows, maxCols);

for (int j = 0; j < maxRows; j++)
{
    for (int k = 0; k < maxCols; k++)
    {
        Console.Write(tableCopy[j, k] + "\t");
    }
    Console.WriteLine();
}

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

        AddNewTableValue(tableCopy, x_Coordinate, y_Coordinate, newValue, maxRows, maxCols);
    }
    else
    {
        Console.Write("Please enter any key to exit... ");
        Console.ReadKey();
        Console.Clear();
        break;
    }
}
