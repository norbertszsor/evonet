namespace EvoNet.Console;

public class MatrixLogic : IMatrixLogic
{
    private readonly Matrix _matrix;

    public MatrixLogic()
    {
        _matrix = new Matrix();
    }
    
    public void Initialize(int length, int width)
    {
        for (var i = 0; i < length; i++)
        {
            for (var j = 0; j < width; j++)
            {
                _matrix.Add(new MatrixCell()
                {
                    Position = new Point() { CordX = i, CordY = j }, 
                    Type = MatrixCellType.Empty
                });
            }
        }
    }

    public void Seed()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    public void UpdateFragment()
    {
        throw new NotImplementedException();
    }

    public void ProvideNearestFragment(int distance)
    {
        throw new NotImplementedException();
    }

    public string Describe()
    {
        return _matrix.Count.ToString();
    }
}