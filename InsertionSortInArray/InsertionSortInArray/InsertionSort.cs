using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortInArray
{
    public class InsertionSort
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = -1;
                int current = i + 1;
                int compareTo = i;
                for (int j = current; j > 0; j--)
                {
                    if (array[current] < array[compareTo])
                    {
                        minIndex = compareTo;
                    }
                    compareTo--;
                }

                if (minIndex != -1)
                {
                    int temp = array[current];
                    for (int k = current; k > minIndex; k--)
                    {
                        array[k] = array[k - 1];
                    }

                    array[minIndex] = temp;
                }
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
