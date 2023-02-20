using EvoNet.Core.Enums;

namespace EvoNet.Core.Transfer.Inner;

public class EnvironmentCell
{
    public EnvironmentPoint? Position { get; set; }
    public EnvironmentCellState Type { get; set; }
}