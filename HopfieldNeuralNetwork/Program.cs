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
            Examples.PrintDigit(five, 5);
            //int[] randomizedFive = Examples.RandomizeDigit(five, 10);
            //Examples.PrintDigit(randomizedFive);

            //var result = Examples.ToBiPolar(five);
            //Examples.PrintDigit(result);

            //var baba = Examples.ToBinary(result);
            //Examples.PrintDigit(baba);

            var transposedFive = Examples.Transpose(five, 5);
            Examples.PrintDigit(transposedFive, 7);

            var m = Examples.Multiply(five, transposedFive, 5, 7);
            Examples.PrintDigit(m, 7);
        }
    }
}
