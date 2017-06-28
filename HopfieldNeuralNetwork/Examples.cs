using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldNeuralNetwork
{
    public static class Examples
    {
        public static void GenerateDigits()
        {

        }

        public static int[] GenerateZero() {
            return new int[35] {
                0, 1, 1, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 1, 1, 0
            };
        }

        public static int[] GenerateOne()
        {
            return new int[35] {
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0
            };
        }

        public static int[] GenerateTwo()
        {
            return new int[35] {
                0, 1, 1, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 1, 1, 1, 0,
                0, 1, 0, 0, 0,
                0, 1, 0, 0, 0,
                0, 1, 1, 1, 0
            };
        }

        public static int[] GenerateThree()
        {
            return new int[35] {
                0, 1, 1, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 1, 1, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 1, 1, 1, 0 };
        }

        public static int[] GenerateFour()
        {
            return new int[35] {
                0, 1, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 1, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0 };
        }

        public static int[] GenerateFive()
        {
            return new int[35] {
                0, 1, 1, 1, 0,
                0, 1, 0, 0, 0,
                0, 1, 0, 0, 0,
                0, 1, 1, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 1, 1, 1, 0 };
        }

        public static int[] GenerateSix()
        {
            return new int[35] {
                0, 1, 1, 1, 0,
                0, 1, 0, 0, 0,
                0, 1, 0, 0, 0,
                0, 1, 1, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 1, 1, 0 };
        }

        public static int[] GenerateSeven()
        {
            return new int[35] {
                0, 1, 1, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0
            };
        }

        public static int[] GenerateEight()
        {
            return new int[35] {
                0, 1, 1, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 1, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 1, 1, 0 };
        }

        public static int[] GenerateNine()
        {
            return new int[35] {
                0, 1, 1, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 1, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 1, 1, 1, 0 };
        }

        public static int[] RandomizeDigit(int[] digit, int percent)
        {
            Random random = new Random();
            
            int itrations = (int)((percent / 100.0) * 35);

            for (int i = 0; i < itrations; i++)
            {
                int bit = random.Next(2);
                int randomIndex = random.Next(35);
                digit[randomIndex] = bit;
            }

            return digit;
        }

        public static void PrintDigit(int[] digit)
        {
            for (int i = 0; i < digit.Length; i++)
            {
                Console.Write(digit[i] + " ");

                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        public static int[] ToBiPolar(int[] input)
        {
            int[] result = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = -1;
                }
            }

            return result;
        }
        
        public static int[] ToBinary(int[] input)
        {
            int[] result = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = 0;
                }
            }

            return result;
        }

        public static int[] Transpose(int[] input)
        {
            int[] result = new int[input.Length];

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    result[(i * 7) + j] = input[(j * 5) + i];
                }
            }

            return result;
        }
    }
}
