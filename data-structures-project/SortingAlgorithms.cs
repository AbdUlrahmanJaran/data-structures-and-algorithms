using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_project
{
    public class SortingAlgorithms
    {
        public static int[] InsertionSort(int[] arr)
        {
            if (arr.Length == 0)
                return null;

            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j-- ;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }
    }
}
