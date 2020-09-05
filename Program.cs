using System;

namespace Task_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8 };

            Shuffle(array);

            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
        static void Shuffle(int[] array)
        {
            Random rand = new Random();
            int maxValue = array.Length;
            
            for (int i = 0; i < maxValue - 1; i++)
            {
                int random = rand.Next(i,maxValue);
                int tempNumber = array[random];
                array[random] = array[i];
                array[i] = tempNumber;
            }
        }
    }
}
