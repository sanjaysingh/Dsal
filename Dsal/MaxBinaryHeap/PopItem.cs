using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.MaxBinaryHeap
{
    public static class PopItemExtension 
    {
        public static int? Pop(this BstMaxBinaryHeap heap)
        {
            int? poppedData = -1;
            if (heap.Count > 0)
            {
                poppedData = heap.Data[0];
                heap.Data[0] = heap.Data[heap.Count - 1];
                heap.Count--;
                heap.HeapifyDown(0);
            }
            return poppedData;
        }
    }
}
