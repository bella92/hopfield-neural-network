using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldNeuralNetwork
{
    public static class Examples
    {
        static Random random = new Random();

        private const int ROWS_COUNT = 7;
        private const int COLS_COUNT = 5;
        private const int NEURONS_COUNT = 35;

        private static int[,] weightMatrix = new int[NEURONS_COUNT, NEURONS_COUNT];

        public static int[][] GenerateDigits()
        {
            int[][] digits = new[]
            {
                GenerateZero(),
                GenerateOne(),
                GenerateTwo(),
                GenerateThree(),
                GenerateFour(),
                GenerateFive(),
                GenerateSix(),
                GenerateSeven(),
                GenerateEight(),
                GenerateNine()
            };

            return digits;
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

        public static int[] RandomizeDigit(int[] matrix, int percent)
        {
            int[] result = new int[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = matrix[i];
            }

            Random random = new Random();
            int bitsCount = (int)((percent / 100.0) * matrix.Length);

            for (int i = 0; i < bitsCount; i++)
            {
                int randomIndex = random.Next(result.Length);

                if (result[randomIndex] == 0)
                {
                    result[randomIndex] = 1;
                }
                else
                {
                    result[randomIndex] = 0;
                }
            }

            return result;
        }

        public static void Print1D(int[] digit, int colsCount)
        {
            for (int i = 0; i < digit.Length; i++)
            {
                string text = digit[i] + " ";

                if (digit[i] == -1)//TODO: remove
                {
                    text = 0 + " ";
                }

                Console.Write(text.PadLeft(3));

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
                    string text = matrix[i, j] + " ";
                    Console.Write(text.PadLeft(3));
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

            //Print2D(weightMatrix);
        }

        public static int[] Run(int[] pattern)
        {
            int[] neurons = new int[pattern.Length];
            for (int i = 0; i < pattern.Length; i++)
            {
                neurons[i] = pattern[i];
            }

            int k = 1;
            int h = 0;
            while (k != 0)
            {
                //var shuffledNeurons = Shuffle(NEURONS_COUNT);

                k = 0;
                for (int i = 0; i < NEURONS_COUNT; i++)
                {
                    //i = shuffledNeurons[i];
                    h = 0;
                    for (int j = 0; j < NEURONS_COUNT; j++)
                    {
                        h += weightMatrix[j, i] * neurons[j];
                    }

                    var old = neurons[i];

                    if (h >= 0)
                    {
                        neurons[i] = 1;
                    }
                    else
                    {
                        neurons[i] = 0;
                    }

                    if (old != neurons[i])
                    {
                        k++;
                    }
                }
            }

            return neurons;//here?!
        }

        static int[] Shuffle(int n)
        {
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = i;
            }

            for (int t = 0; t < n; t++)
            {
                int temp = result[t];
                
                int r = random.Next(t, n);
                result[t] = result[r];
                result[r] = temp;
            }

            return result;
        }
    }
}
