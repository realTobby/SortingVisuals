using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisuals
{
    public class BubbleSort : BaseSort
    {

        int pointerIndex = 0;

        public override void DoSort()
        {
            if (pointerIndex >= currentSort.Count-1)
                pointerIndex = 0;

            if(currentSort[pointerIndex] > currentSort[pointerIndex + 1])
            {
                SwapNumbers(pointerIndex, pointerIndex + 1);
            }

            pointerIndex++;
            SetCurrentSort(currentSort);
        }


    }
}
