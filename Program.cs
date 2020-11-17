using System;

namespace arrayNewReversedNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter please array size = ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); 
            }
            string numbersToString = string.Join(", ", numbers);
            Console.WriteLine(numbersToString);
            

        }
    }
}
