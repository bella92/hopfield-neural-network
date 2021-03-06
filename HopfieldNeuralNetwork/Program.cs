﻿using System;
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
            int[][] digits = new int[3][] {
                new int[100] {
                    0, 0, 0, 1, 1, 1, 1, 0, 0, 0,
                    0, 0, 1, 1, 1, 1, 1, 1, 0, 0,
                    0, 1, 1, 1, 0, 0, 1, 1, 1, 0,
                    0, 1, 1, 0, 0, 0, 0, 1, 1, 0,
                    0, 1, 1, 0, 0, 0, 0, 1, 1, 0,
                    0, 1, 1, 0, 0, 0, 0, 1, 1, 0,
                    0, 1, 1, 0, 0, 0, 0, 1, 1, 0,
                    0, 1, 1, 1, 0, 0, 1, 1, 1, 0,
                    0, 0, 1, 1, 1, 1, 1, 1, 0, 0,
                    0, 0, 0, 1, 1, 1, 1, 0, 0, 0
                },
                new int[100] {
                    0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 
                    0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 
                    0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 
                    0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 
                    0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 
                    0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 
                    0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 
                    0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 
                    0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 
                    0, 0, 1, 1, 1, 1, 1, 1, 0, 0
                },
                new int[100] {
                    0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 
                    0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 
                    0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 
                    0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 
                    0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 
                    0, 0, 0, 0, 0, 1, 1, 0, 0, 0,
                    0, 0, 0, 0, 0, 1, 1, 0, 0, 0,
                    0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 
                    0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 
                    0, 0, 0, 1, 1, 1, 1, 1, 0, 0
                }
            };

            for (int i = 0; i < digits.Length; i++)
            {
                int[] biPolarPattern = Examples.ToBiPolar(digits[i]);
                Examples.Train(biPolarPattern);
            }

            int[] test = digits[0];
            //int[] biPolarTest = Examples.ToBiPolar(test);
            int[] randomizedTest = Examples.RandomizeDigit(test, 30);
            Examples.Print1D(randomizedTest, 10);

            int[] result = Examples.Run(randomizedTest);
            //int[] binaryResult = Examples.ToBinary(result);
            Examples.Print1D(result, 10);

            //int[] pattern = new int[] { 0, 1, 1, 0, 1 };
            //int[] biPolarPattern = Examples.ToBiPolar(pattern);
            //Examples.Train(biPolarPattern);

            //int[] pattern1 = new int[] { 1, 0, 1, 0, 1 };
            //int[] biPolarPattern1 = Examples.ToBiPolar(pattern1);
            //Examples.Train(biPolarPattern1);

            //int[] test = new int[] { 1, 1, 1, 1, 1 };

            //int[] biPolarTest = Examples.ToBiPolar(test);
            //Examples.Print1D(biPolarTest, 5);

            //int[] result = Examples.Run(test);
            //int[] binaryResult = Examples.ToBinary(result);
            //Examples.Print1D(binaryResult, 5);
        }
    }
}
