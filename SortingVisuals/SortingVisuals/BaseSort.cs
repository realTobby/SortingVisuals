using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisuals
{
    public abstract class BaseSort
    {
        private Random rnd = new Random();
        public List<int> currentSort = new List<int>();

        public void SetEntries(int count, int maxValue)
        {
            for (int i = 0; i < count; i++)
            {
                currentSort.Add(rnd.Next(0, maxValue));
            }
        }

        public List<int> GetCurrentSort()
        {
            return currentSort;
        }

        public void SetCurrentSort(List<int> sortList)
        {
            currentSort = sortList;
        }

        public abstract void DoSort();

        public void SwapNumbers(int one, int two)
        {
            int tmp = currentSort[one];
            currentSort[one] = currentSort[two];
            currentSort[two] = tmp;
        }

    }
}
