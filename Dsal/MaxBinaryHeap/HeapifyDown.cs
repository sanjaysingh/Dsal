using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.MaxBinaryHeap
{
    public static class HeapifyDownExtension
    {
        public static BstMaxBinaryHeap HeapifyDown(this BstMaxBinaryHeap heap, int index)
        {
            int largest = index;
            int left = 2 * index + 1;
            int right = left + 1;

            if (left < heap.Count && heap.Data[left] > heap.Data[largest]) largest = left;
            if (right < heap.Count && heap.Data[right] > heap.Data[largest]) largest = right;

            if (largest != index)
            {
                int temp = heap.Data[index];
                heap.Data[index] = heap.Data[largest];
                heap.Data[largest] = temp;
                return HeapifyDown(heap, largest);
            }

            return heap;
        }
    }
}
