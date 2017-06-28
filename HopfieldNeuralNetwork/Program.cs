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
            int[] five = Examples.GenerateFive();
            //int[] randomizedFive = Examples.RandomizeDigit(five, 10);
            //Examples.PrintDigit(randomizedFive);

            //var result = Examples.ToBiPolar(five);
            //Examples.PrintDigit(result);

            //var baba = Examples.ToBinary(result);
            //Examples.PrintDigit(baba);

            var transposedFive = Examples.Transpose(five);
            Examples.PrintDigit(transposedFive);
        }
    }
}
