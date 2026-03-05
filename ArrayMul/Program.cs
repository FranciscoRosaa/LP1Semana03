using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 6)
            {
                Console.WriteLine("Not enough arguments!");
                return;
            }
            float[,] A = new float[2, 2];
            float[] B = new float[2];
            float[] result = new float[2];

            A[0, 0] = float.Parse(args[0]);
            A[0, 1] = float.Parse(args[1]);
            A[1, 0] = float.Parse(args[2]);
            A[1, 1] = float.Parse(args[3]);
            B[0] = float.Parse(args[4]);
            B[1] = float.Parse(args[5]);

            for (int i = 0; i < 2; i++)
            {
                result[i] = 0;
                for (int j = 0; j < 2; j++)
                {
                    result[i] += A[i, j] * B[j];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"| {result[i],7:F2} |");
            }
        }
    }
}