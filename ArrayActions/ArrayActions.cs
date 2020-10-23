using System;

namespace ArrayActions
{
    public class ArrayMethods
    {
        static public double SumNegative(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    sum += arr[i];
            }
            return sum;
        }
        static public double MaxElement(double[] arr)
        {
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        static public int MaxElementIndex(double[] arr)
        {
            double max = arr[0];
            int i_max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    i_max = i;
                }
            }
            return i_max;
        }
        static public double MaxElementByModule(double[] arr)
        {
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(max))
                    max = arr[i];
            }
            return max;
        }
        static public int MaxElementByModuleIndex(double[] arr)
        {
            double max = arr[0];
            int i_max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(max))
                {
                    max = arr[i];
                    i_max = i;
                }
            }
            return i_max;
        }

        static public double SumOfPositiveNumberIndexes(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    sum += i;
            }
            return sum;
        }
        static public int AmountOfIntegerNumbers(double[] arr)
        {
            int colvo = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 1 == 0)
                    colvo++;
            }
            return colvo;
        }
        static public void ArraySort(double[] arr)
        {
            double temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static public int AmountOfPositiveNumbers(double[] arr)
        {
            int colvo = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                    colvo++;
            }
            return colvo;
        }
        static public double[] DeleteNagativeNumbers(double[] arr)
        {
            double[] newArr = new double[AmountOfPositiveNumbers(arr)];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            return newArr;
        }

    }
}
