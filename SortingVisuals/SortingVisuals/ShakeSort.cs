using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisuals
{
    class ShakeSort : BaseSort
    {
        public override void DoSort()
        {
            for (int i = 0; i < currentSort.Count / 2; i++)
            {
                bool swapped = false;
                for (int j = i; j < currentSort.Count - i - 1; j++)
                {
                    if (currentSort[j] < currentSort[j + 1])
                    {
                        SwapNumbers(j, i);
                    }
                }
                for (int j = currentSort.Count - 2 - i; j > i; j--)
                {
                    if (currentSort[j] > currentSort[j - 1])
                    {
                        SwapNumbers(j, i);
                    }
                }
                if (!swapped) break;
            }
        }
    }
}
