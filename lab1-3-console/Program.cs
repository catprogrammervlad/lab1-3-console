using System;

namespace lab1_3_console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявляем двумерный массив
            int[,] array2d = new int[5, 5];
            int[] array1d = new int[5];

            Random ran = new Random();

            // Инициализируем данный массив
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array2d[i, j] = ran.Next(-15, 15);
                    Console.Write("{0}\t", array2d[i, j]);
                }
                Console.WriteLine();
            }
            
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    
                    if(array2d[i, j] > 0)
                    {
                        array1d[j]++;
                    }
 
                }
                
            }


            for (int i = 0; i < 5; i++)
            {
                Console.Write(array1d[i] + " ");

            }
        }
    }
}
