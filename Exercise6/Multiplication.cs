using System;
public class Multiplication
{
    public int maxRow;
    public int maxCol;
    public int[,] table;
    public Multiplication(int aMaxRow, int aMaxCol)
    {
        maxRow = aMaxRow;
        maxCol = aMaxCol;
        table = new int[maxRow, maxCol];
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
        
        for (int x = 0; x < table.GetLength(0); x++)
        {
            for (int y = 0; y < table.GetLength(1); y++)
            {
                Console.Write(table[x, y] + "\t");
            }
            Console.WriteLine();
        }
    }
}