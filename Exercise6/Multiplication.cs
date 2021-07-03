using System;

public class MultiplicationTable
{
    public int maxRow;
    public int maxCol;
    public int[,] table;
    public bool[,] modifiedTable;
  
    public MultiplicationTable(int aMaxRow, int aMaxCol)
    {
        maxRow = aMaxRow;
        maxCol = aMaxCol;
        table = new int[maxRow, maxCol];
        modifiedTable = new bool[maxRow, maxCol];
    }

    public void GenerateTable()
    {
        for (int x = 0; x < table.GetLength(0); x++)
        {
            for (int y = 0; y < table.GetLength(1); y++)
            {
                table[x, y] = (x + 1) * (y + 1);
                Console.Write(table[x, y] + "\t");
            }
            Console.WriteLine();
        }
    }

    public void ChangeTableValue(int xCoordinate, int yCoordinate, int newValue)
    {
        table[xCoordinate, yCoordinate] = newValue;
        modifiedTable[xCoordinate, yCoordinate] = true;
    }

    public void DisplayTable()
    {
        for (int x = 0; x < table.GetLength(0); x++)
        {
            for (int y = 0; y < table.GetLength(1); y++)
            {
                if(modifiedTable[x,y])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(table[x,y] + "\t");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(table[x,y] + "\t");
                }
            }
            Console.WriteLine();
        }
    }
        
}