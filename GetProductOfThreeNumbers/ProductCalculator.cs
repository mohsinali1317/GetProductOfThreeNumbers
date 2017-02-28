using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetProductOfThreeNumbers
{
    public class ProductCalculator
    {

        public int CalculateProduct(int[] array)
        {

            if (array.Length < 3)
                throw new Exception("We are excepting array with atleast size 3");

            if (array.Length == 3)
                return Product(array);

            QuickSortNow(array, 0, array.Length - 1);

            return Product(array);

        }

        private int Product(int [] array)
        {
            return array[0] * array[1] * array[2];
        }

        public static void QuickSortNow(int[] iInput, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(iInput, start, end);
                QuickSortNow(iInput, start, pivot - 1);
                QuickSortNow(iInput, pivot + 1, end);
            }
        }

        public static int Partition(int[] iInput, int start, int end)
        {
            int pivot = iInput[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (iInput[i] >= pivot)
                {
                    int temp = iInput[i];
                    iInput[i] = iInput[pIndex];
                    iInput[pIndex] = temp;
                    pIndex++;
                }
            }

            int anotherTemp = iInput[pIndex];
            iInput[pIndex] = iInput[end];
            iInput[end] = anotherTemp;
            return pIndex;
        }

    }
}
