using EvoNet.Core.Enums;
using EvoNet.Core.Transfer.Inner;
using EvoNet.Interfaces.Core.Services;
using EvoNet.Core.Transfer.Inner;
using EnvironmentMatrix = EvoNet.Core.Transfer.Inner.EnvironmentMatrix;

namespace EvoNet.Core.Services;

public class EnvironmentLogic : IEnvironmnetLogic
{
    private readonly EnvironmentMatrix _matrix = new();

    public void Initialize(int length, int width)
    {
        for (var i = 0; i < length; i++)
        {
            for (var j = 0; j < width; j++)
            {
                _matrix.Add(new EnvironmentCell()
                {
                    Position = new EnvironmentPoint() { CordX = i, CordY = j },
                    Type = EnvironmentCellState.Empty
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