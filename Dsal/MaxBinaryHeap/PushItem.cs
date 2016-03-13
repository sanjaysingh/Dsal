using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.MaxBinaryHeap
{
    public static class PushItemExtension 
    {
        public static BstMaxBinaryHeap Push(this BstMaxBinaryHeap heap, int item)
        {
            if (heap.Count == heap.Data.Length)
            {
                int[] newDataArray = new int[2 * heap.Count];
                Array.Copy(heap.Data, newDataArray, heap.Count);
                heap.Data = newDataArray;
            }
            heap.Data[heap.Count++] = item;
            heap.HeapifyUp(heap.Count - 1);

            return heap;
        }
    }
}
