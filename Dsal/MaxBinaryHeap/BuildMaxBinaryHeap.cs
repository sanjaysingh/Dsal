using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.MaxBinaryHeap
{
    public static class BuildMaxBinaryHeap 
    {
        public static BstMaxBinaryHeap BuildFrom(this BstMaxBinaryHeap heap, int[] data)
        {
            heap.Data = data;
            heap.Count = data.Length;
            for (int i = heap.Count / 2; i >= 0; i--)
            {
                heap.HeapifyDown(i);
            }

            return heap;
        }

    }
}
