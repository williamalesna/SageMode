public class MultiplicationTable
{
    private int[,] InternalTable { get; set; }
    private bool[,] ModifiedTable { get; set; }

    public int[,] Table
    {
        get { return InternalTable.Clone() as int[,]; }
    }

    public MultiplicationTable(int maxRow, int maxCol)
    {
        InternalTable = new int[maxRow, maxCol];
        ModifiedTable = new bool[maxRow, maxCol];
        ResetTable();
    }

    public void SetValueInCoordinate(int x, int y, int value)
    {
        InternalTable[x, y] = value;
        ModifiedTable[x, y] = true;
    }

    public bool IsCoordinatesModified(int x, int y)
    {
        return ModifiedTable[x, y];
    }

    public void ResetTable()
    {
        for (var x = 0; x < InternalTable.GetLength(0); x++)
        {
            for (var y = 0; y < InternalTable.GetLength(1); y++)
            {
                InternalTable[x, y] = (x + 1) * (y + 1);
                ModifiedTable[x, y] = false;
            }
        }
    }
}