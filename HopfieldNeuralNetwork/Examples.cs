using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldNeuralNetwork
{
    public static class Examples
    {
        private const int ROWS_COUNT = 7;
        private const int COLS_COUNT = 5;
        private const int NEURONS_COUNT = 4;

        private static int[,] weightMatrix = new int[NEURONS_COUNT, NEURONS_COUNT];

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
                0, 1, 1, 1, 0
            };
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
                0, 0, 0, 1, 0
            };
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
                0, 1, 1, 1, 0
            };
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
                0, 1, 1, 1, 0
            };
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
                0, 1, 1, 1, 0
            };
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
                0, 1, 1, 1, 0
            };
        }

        public static int[] RandomizeDigit(int[] matrix, int percent, int colsCount)
        {
            int rowsCount = matrix.Length / colsCount;
            Random random = new Random();
            
            int bitsCount = (int)((percent / 100.0) * rowsCount * colsCount);

            for (int i = 0; i < bitsCount; i++)
            {
                int randomIndex = random.Next(rowsCount * colsCount);
                matrix[randomIndex] = -matrix[randomIndex];
            }

            return matrix;
        }

        public static void Print1D(int[] digit, int colsCount)
        {
            for (int i = 0; i < digit.Length; i++)
            {
                Console.Write(digit[i] + " ");

                if ((i + 1) % colsCount == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }

        public static void Print2D(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
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

        public static int[] GetColumn(int[] matrix, int column, int colsCount)
        {
            int rowsCount = matrix.Length / colsCount;
            int[] result = new int[rowsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                result[i] = matrix[(colsCount * i) + column];
            }

            return result;
        }

        public static int[] GetRow(int[] matrix, int row, int colsCount)
        {
            int[] result = new int[colsCount];

            Array.Copy(matrix, row * colsCount, result, 0, colsCount);

            return result;
        }

        //public static int[] Transpose(int[] matrix, int colsCount)
        //{
        //    int rowsCount = matrix.Length / colsCount;
        //    int[] result = new int[matrix.Length];

        //    for (int i = 0; i < colsCount; i++)
        //    {
        //        Array.Copy(GetColumn(matrix, i, colsCount), 0, result, i * rowsCount, rowsCount);
        //    }

        //    return result;
        //}

        public static void Train(int[] pattern)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (i == j)
                    {
                        weightMatrix[i, j] = 0;
                    }
                    else
                    {
                        weightMatrix[i, j] += (pattern[i] * pattern[j]);
                    }
                }
            }

            Print2D(weightMatrix);
        }

        public static int[] ClearDiagonal(int[] matrix, int colsCount)
        {
            int rowsCount = matrix.Length / colsCount;
            int[] result = new int[matrix.Length];

            for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < colsCount; colIndex++)
                {
                    int index = (rowIndex * colsCount) + colIndex;

                    if (rowIndex == colIndex)
                    {
                        result[index] = 0;
                    }
                    else
                    {
                        result[index] = matrix[index];
                    }
                }
            }

            return result;
        }
    }
}
