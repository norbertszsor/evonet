using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoNet.Core.Transfer.Inner
{
    public class NeuralNetwork
    {
        public int InputSize { get; set; }
        public int OutputSize { get; set; }
        public int HiddenSize { get; set; }
        public List<double[]>? Weights { get; set; }
    }
}
