using System;

namespace BitwiseOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            const int M = 5; 

            int[,] array = new int[M, M];

            int coordX = 3;
            int coordY = 2;

            for (int i = 0; i < M; i++) 
            {
                for (int j = 0; j < M; j++) 
                {
                    array[i, j] = 0;
                    Console.Write(array[i, j]);
                }
                Console.Write('\n');
            }


        }
    }
}
