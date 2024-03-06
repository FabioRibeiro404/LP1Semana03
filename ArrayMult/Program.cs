using System;
using System.Globalization;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.DefaultThreadCurrentCulture =
                CultureInfo.InvariantCulture;

            float [,] matrix1 = new float [2, 2];
            float [,] matrix2 = new float [2, 1];
            float [,] result = new float[matrix1.GetLength(0), matrix2.GetLength(1)];
            float [] nums = new float [args.Length];   
            
            for (int i = 0; i < args.Length; i++)
            {
                nums[i] = float.Parse(args[i]);
                Console.WriteLine(nums[i] + " ");
            }

            Console.WriteLine();

            int counter = 0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i,j] = nums [counter];
                    Console.Write($"({matrix1[i,j]}){i}/{j} ");
                    counter++;
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i,j] = nums [counter];
                    Console.Write($"({matrix2[i,j]}){i}/{j} ");
                    counter++;
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            Console.WriteLine("Result:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
            
        }
    }
}
