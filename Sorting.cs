using System;
using System.Collections.Generic;

namespace CoreView
{
	public static class Sorting
	{
        private static Random Random = new Random();
        public enum Order
        {
            Ascending,
            Descending
        }

        /// <summary>
        /// Quick sort interface. 
        /// </summary>
        /// <typeparam name="T">Any IComparable type (or a type with a given Comparer)</typeparam>
        /// <param name="array">The array to sort</param>
        /// <param name="ascending">True if ascending order required, false for descending</param>
        /// <param name="comparer">If type is not IComparable, provide a Comparer</param>
        /// Using a type variable means any datatype can be sent as long as it has a type comparer
        /// Can specify a type comparer or not. If not specified, default is used.
        public static void QuickSort<T>(T[] array, Order order) { QuickSort(array, order, Comparer<T>.Default); }
        public static void QuickSort<T>(T[] array, Order order, Comparer<T> comparer)
		{
            // If the array is null, don't do anything to it
            if (array.Length > 0)
            {
                // Always do a standard sort in ascending order
                int left = 0;
                int right = array.Length - 1;
                QuickSortFunction(array, left, right, comparer);

                if (order == Order.Descending)
                {
                    // If not ascending order, reverse by swapping outside to inside
                    for (int i = 0; i < array.Length / 2; i++)
                    {
                        Swap(array, i, (array.Length - 1) - i);
                    }
                }
            }
		}

        private static void QuickSortFunction<T>(T[] array, int start, int end, Comparer<T> comparer)
        {
            if (end - start >= 1)
            {
                int leftPtr, rightPtr, pivot;
                Random random = new Random();
                pivot = random.Next(start, end);
                Swap(array, pivot, start);
                pivot = start;

                leftPtr = start;
                rightPtr = end;

                while (leftPtr < rightPtr)
                {
                    while ((comparer.Compare(array[leftPtr], array[pivot])) < 0 && (leftPtr < rightPtr))
                    {
                        leftPtr++;
                    }

                    while ((comparer.Compare(array[rightPtr], array[pivot])) >= 0 && (leftPtr < rightPtr))
                    {
                        rightPtr--;
                    }

                    if (leftPtr < rightPtr)
                    {
                        Swap(array, leftPtr, rightPtr);
                    }
                }
                Swap(array, pivot, rightPtr);
                pivot = rightPtr;

                QuickSortFunction(array, start, pivot - 1, comparer);
                QuickSortFunction(array, pivot + 1, end, comparer);
            }
        }


        private static void Swap<T>(T[] array, int pointer1, int pointer2)
        {
            T temp = array[pointer1];
            array[pointer1] = array[pointer2];
            array[pointer2] = temp;
        }
	}
}