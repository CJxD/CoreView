using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoreView
{
	public static class Sorting
	{
        public enum Order
        {
            Ascending,
            Descending
        }

        /// <summary>
        /// Main sorting interface. Used to be a custom Quicksort function, but that got deprecated.
        /// </summary>
        /// <typeparam name="T">Any IComparable type (or a type with a given Comparer)</typeparam>
        /// <param name="array">The array to sort</param>
        /// <param name="order">The sorting order, Ascending or Descending</param>
        /// <param name="comparer">If type is not IComparable, provide a Comparer</param>
        /// Using a type variable means any datatype can be sent as long as it has a type comparer
        /// Can specify a type comparer or not. If not specified, default is used.
        public static void Sort<T>(T[] array, Order order) { Sort(array, order, Comparer<T>.Default); }
        public static void Sort<T>(T[] array, Order order, Comparer<T> comparer)
		{
            // If the array is null, don't do anything to it
            if (array.Length > 0)
            {
                Array.Sort<T>(array, comparer);

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

        private static void Swap<T>(T[] array, int pointer1, int pointer2)
        {
            T temp = array[pointer1];
            array[pointer1] = array[pointer2];
            array[pointer2] = temp;
        }
	}

    public class ListViewSorter
    {
        private ListView listRef;
        public int SortedColumn { get; set; }
        public Sorting.Order SortedColumnOrder { get; set; }

        public ListViewSorter(ListView list)
        {
            listRef = list;
            SortedColumn = -1;
        }

        /// <summary>
        /// Sorts the List View object on the selected column.
        /// </summary>
        /// <param name="column">The index of the column to sort</param>
        /// <param name="order">The sorting order, Ascending or Descending</param>
        public void Sort(int column)
        {
            if (column == SortedColumn)
            {
                // If currently in ascending order, make descending
                if (SortedColumnOrder == Sorting.Order.Ascending)
                {
                    Sort(column, Sorting.Order.Descending);
                }
                else
                {
                    Sort(column, Sorting.Order.Ascending);
                }
            }
            else
            {
                Sort(column, Sorting.Order.Ascending);
            }
        }
        public void Sort(int column, Sorting.Order order)
        {
            // Copy the list view items into an array
            ListViewItem[] items = new ListViewItem[listRef.Items.Count];
            listRef.Items.CopyTo(items, 0);

            Sorting.Sort(items, order, new ListViewComparer(column));

            // Copy the sorted list back into the List View
            listRef.Items.Clear();
            listRef.Items.AddRange(items);

            // Set the sorted column information
            SortedColumn = column;
            SortedColumnOrder = order;
        }
    }

    // Class for comparing list view objects
    public class ListViewComparer : Comparer<ListViewItem>
    {
        private int listViewColumn = 0;

        // Constructor to store the column number to be read
        public ListViewComparer(int ListViewColumn)
        {
            this.listViewColumn = ListViewColumn;
        }

        public override int Compare(ListViewItem aRow, ListViewItem bRow)
        {
            string aItem = aRow.SubItems[listViewColumn].Text;
            string bItem = bRow.SubItems[listViewColumn].Text;

            // If the item is a date in the form dd/mm/yyyy, then return a date comparison
            DateTime aDate, bDate;
            if (DateTime.TryParse(aItem, out aDate) && DateTime.TryParse(bItem, out bDate))
            {
                return aDate.CompareTo(bDate);
            }
            else
            {
                // Using Vasian Cepa's code for logical string comparing, more useful results are obtained
                return StringLogicalComparer.Compare(aItem, bItem);
            }
        }
    }
}