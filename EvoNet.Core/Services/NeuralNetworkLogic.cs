using EvoNet.Core.Transfer.Inner;
using EvoNet.Interfaces.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoNet.Core.Services
{
    public class NeuralNetworkLogic : INeuralNetworkLogic
    {
        private readonly NeuralNetwork _neuralNetwork;

        public NeuralNetworkLogic(NeuralNetwork neuralNetwork)
        {
            _neuralNetwork = neuralNetwork;
        }

        public List<double> ProvideOutput(List<double> input)
        {
            var hidden = new List<double>();
            var output = new List<double>();

            for (var i = 0; i < _neuralNetwork.HiddenSize; i++)
            {
                var sum = 0.0;

                for (var j = 0; j < _neuralNetwork.InputSize; j++)
                {
                    sum += input[j] * _neuralNetwork.Weights![0][j * _neuralNetwork.HiddenSize + i];
                }

                hidden.Add(ActivationFunction(sum));
            }

            for (var i = 0; i < _neuralNetwork.OutputSize; i++)
            {
                var sum = 0.0;

                for (var j = 0; j < _neuralNetwork.HiddenSize; j++)
                {
                    sum += hidden[j] * _neuralNetwork.Weights![1][j * _neuralNetwork.OutputSize + i];
                }

                output.Add(ActivationFunction(sum));
            }

            return output;
        }

        private static double ActivationFunction(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }
    }
}
