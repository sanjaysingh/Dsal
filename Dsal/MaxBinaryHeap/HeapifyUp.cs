using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.MaxBinaryHeap
{
    public static class HeapifyUpExtension
    {
        public static BstMaxBinaryHeap HeapifyUp(this BstMaxBinaryHeap heap, int index)
        {
            int parentIndex = (index - 1) / 2;
            if (parentIndex >= 0 && parentIndex < heap.Count && heap.Data[parentIndex] < heap.Data[index])
            {
                int temp = heap.Data[parentIndex];
                heap.Data[parentIndex] = heap.Data[index];
                heap.Data[index] = temp;
                return HeapifyUp(heap, parentIndex);
            }

            return heap;
        }
    }
}
