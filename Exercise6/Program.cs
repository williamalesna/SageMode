using System;

Console.Clear();
Console.WriteLine("GENERATE MULTIPLICATION TABLE");
Console.Write("Enter Max Row: ");
int maxRow = int.Parse(Console.ReadLine());
Console.Write("Enter Max Column: ");
int maxCol = int.Parse(Console.ReadLine());

int[,] table = new int[maxRow, maxCol];

for(int x = 0; x < table.GetLength(0); x++)
{
    for(int y = 0; y < table.GetLength(1); y++)
    {
        table[x,y] = (x + 1) * (y + 1);
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("--------------------------------------------------------------------------------");
Console.ResetColor();

for(int x = 0; x < table.GetLength(0); x++)
{
    for(int y = 0; y < table.GetLength(1); y++)
    {
        Console.Write(table[x,y] + "\t");
    }
    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("--------------------------------------------------------------------------------");
Console.ResetColor();

int[,] duplicateTable = table;

while(true)
{
    Console.Write("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    Console.Write("Do you want to change a number in any coordinate? (y/n): ");
    string choice = Console.ReadLine();

    if(choice == "y" | choice == "Y")
    {
        Console.Write("Enter coordinate X: ");
        int xCoordinate = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter coordinate y: ");
        int yCoordinate = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter new value: ");
        int newValue = int.Parse(Console.ReadLine());

        duplicateTable[xCoordinate, yCoordinate] = newValue;
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nNEWLY EDITED TABLE");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.ResetColor();

        for(int x = 0; x < duplicateTable.GetLength(0); x++)
        {
            for(int y = 0; y < duplicateTable.GetLength(1); y++)
            {
                if(newValue == duplicateTable[x,y])
                {   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(duplicateTable[x,y] + "\t");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(duplicateTable[x,y] + "\t");
                }
               
            }
            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.ResetColor();
    }
    else
    {
        Console.Write("Press any key to exit... ");
        Console.ReadKey();
        Console.Clear();
        break;
    }
    
}


