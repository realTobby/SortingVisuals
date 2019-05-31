using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisuals
{
    class SelectionSort : BaseSort
    {
        public int pointerIndex = 0;

        public override void DoSort()
        {
            if (pointerIndex >= currentSort.Count)
                pointerIndex = 0;

            for(int i = 0; i < currentSort.Count; i++)
            {
                if(currentSort[i] < currentSort[pointerIndex])
                {
                    int tmp = currentSort[pointerIndex];
                    currentSort[pointerIndex] = currentSort[i];
                    currentSort[i] = tmp;
                    break;
                }

            }


            pointerIndex++;
            SetCurrentSort(currentSort);
        }
    }
}
