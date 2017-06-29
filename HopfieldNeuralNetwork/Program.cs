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
            //int[] five = Examples.GenerateFive();
            //Examples.Print(five, 5);

            //var transposedFive = Examples.Transpose(five, 5);
            //Examples.Print(transposedFive, 7);

            //var m = Examples.Multiply(five, transposedFive, 5, 7);
            //Examples.Print(m, 7);

            //var clearedFive = Examples.ClearDiagonal(m, 7);
            //Examples.Print(clearedFive, 7);

            int[] pattern = new int[] { 0, 1, 0, 1 };
            var biPolarPattern = Examples.ToBiPolar(pattern);
            Examples.Train(biPolarPattern);
        }
    }
}
