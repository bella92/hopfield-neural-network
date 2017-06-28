using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldNeuralNetwork
{
    public static class NeuralNetwork
    {
        public static void Train(int[] pattern)
        {
            int[] polarPattern = Examples.ToBiPolar(pattern);
        }
    }
}
