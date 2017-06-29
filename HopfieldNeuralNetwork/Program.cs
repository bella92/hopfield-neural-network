using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldNeuralNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] digits = Examples.GenerateDigits();

            for (int i = 0; i < digits.Length - 1; i++)
            {
                int[] biPolarPattern = Examples.ToBiPolar(digits[i]);
                Examples.Train(biPolarPattern);
            }

            int[] test = Examples.GenerateTwo();
            int[] randomizedTest = Examples.RandomizeDigit(test, 10);
            Examples.Print1D(randomizedTest, 5);

            int[] result = Examples.Run(randomizedTest);
            Examples.Print1D(result, 5);
        }
    }
}
