using System;

namespace ConsoleApp3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] array = { 1, 2, 3, 4, 5, 6, 7 };           

            Console.WriteLine("Исходный массив");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.Write("\nВведите количество сдвигов: ");

            int amountOfMoves = Convert.ToInt32(Console.ReadLine());            

            for (int i = 0; i < amountOfMoves; i++)
            {
                int first= array[0];

                for (int j = 0; j < array.Length-1; j++)
                {                    
                    array[j] = array[j+1];
                    
                }
                array[array.Length - 1] = first;
            }

            Console.WriteLine("Получившийся массив");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] +" " );
            }
        }
    }
}
