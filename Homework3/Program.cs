using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int block, lenght;
            do
            {
                Console.WriteLine("Enter blocks 1-10:");
                int.TryParse(Console.ReadLine(), out block);

                Console.WriteLine("Enter lenght 1-10:");
                int.TryParse(Console.ReadLine(), out lenght);

                if (block <1 || lenght <= 1 && block > 10 || lenght > 10) 
                Console.WriteLine("Error input!");
            }
            while (block < 1 || block > 10 || lenght < 1 || lenght > 10);                   

            int[,] array = new int[block, lenght];
            int min = 9;
            int max = 0;
            double avg = 0;
            Random run = new Random();

            for (int i = 0; i < block; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    array[i, j] = run.Next(0, 10);
                    avg = avg + array[i, j];
                    min = min > array[i,j] ? array[i,j] : min;
                    max = max < array[i, j] ? array[i, j] : max;
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Average value: {avg / array.Length}\nMin value: {min}\nMax value: {max}");
            Console.WriteLine();

            for (int i = 0; i < block; i++)
            {
                int cell = 1;
                for (int j = 0; j < lenght; j++)
                {
                    array[i, j] = j <= i && i + j >= block - 1 || j >= i && i + j <= block - 1 ? cell++ : 0;
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < block; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    array[i, j] = i == 0 || j == 0 || i == block - 1 || j == lenght - 1? 1 : 0;
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < block; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    array[i, j] = j == i || i + j == block - 1 ? 1 :0;
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
