using System;

int maxRows, maxCols;
Console.WriteLine("GENERATE MULTIPLACATION TABLE");
Console.Write("Enter Max Row: ");
maxRows = int.Parse(Console.ReadLine());
Console.Write("Enter Max Column: ");
maxCols = int.Parse(Console.ReadLine());
Console.WriteLine("--------------------------------------------------");

int[,] table = new int[maxRows,maxCols]; 

for(int x = 0; x < maxRows; x++)
{
    for(int y = 0; y < maxCols; y++)
    {
        table[x, y] = (x + 1) * (y + 1);
        Console.Write(table[x,y] + "\t");
    }   
    Console.WriteLine();
}

