public class MultiplicationTableGenerator
{
    private int[,] _internalTable;
    private bool[,] _modifiedTable;

    public int[,] Table
    {
        get { return GenerateTableValue().Clone() as int[,]; }
    }

    public bool[,] ModifiedTable
    {
        get { return _modifiedTable; }
    }

    public MultiplicationTableGenerator(int maxRow, int maxCol)
    {
        _internalTable = new int[maxRow, maxCol];
        _modifiedTable = new bool[maxRow, maxCol];
    }

    private int[,] GenerateTableValue()
    {
        for (int x = 0; x < _internalTable.GetLength(0); x++)
        {
            for (int y = 0; y < _internalTable.GetLength(1); y++)
            {
                _internalTable[x, y] = (x + 1) * (y + 1);
            }
        }
        return _internalTable;
    }
}