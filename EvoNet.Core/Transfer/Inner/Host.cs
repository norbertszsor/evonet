using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoNet.Core.Transfer.Inner
{
    public class Host
    {
        public NeuralNetwork? Network { get; set; }
        public EnvironmentPoint? EnvironmentPoint { get; set; }
        public List<HostGenoType>? Genotypes { get; set; }
        public bool IsAlive { get; set; }
        public bool IsAncestor { get; set; }
    }
}
