namespace Assignment5
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            int[,] twoDArray = {
            {1, 2, 3},
            {4, 5, 6}
        };

   
            Console.WriteLine("Two-dimensional array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(twoDArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
