using System;
using ArrayActions;

namespace Task
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter amount of numbers in array:"); int amount = int.Parse(Console.ReadLine());
            double[] arr = new double[amount];
            Console.WriteLine($"Fill array with {amount} numbers:");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"index {i} = ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum of negative numbers: {ArrayMethods.SumNegative(arr)}");
            Console.WriteLine($"Max element in array: {ArrayMethods.MaxElement(arr)}, and it's index is: {ArrayMethods.MaxElementIndex(arr)}");
            Console.WriteLine($"Max number by module: {ArrayMethods.MaxElementByModule(arr)}, and it's index is: {ArrayMethods.MaxElementByModuleIndex(arr)}");
            Console.WriteLine($"Sum of positive indexes: {ArrayMethods.SumOfPositiveNumberIndexes(arr)}");
            Console.WriteLine($"Amount of integer numbers: {ArrayMethods.AmountOfIntegerNumbers(arr)}");
            Console.WriteLine("Sorted array:");
            ArrayMethods.ArraySort(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"index {i} = " +arr[i] + "\n");
            Console.WriteLine("Array with deleted negative numbers:");
            arr = ArrayMethods.DeleteNagativeNumbers(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"index {i} = " + arr[i] + "\n");

        }
    }
}
