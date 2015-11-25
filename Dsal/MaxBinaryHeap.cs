using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal
{
    public class MaxBinaryHeap
    {
        private int[] data;
        private int count = 0;

        public MaxBinaryHeap(int[] data)
        {
            this.data = data;
            count = data.Length;
            BuildHeap();
        }

        public void  Push(int value)
        {
            if(count == data.Length)
            {
                int[] newDataArray = new int[2 * count];
                Array.Copy(data, newDataArray, count);
                data = newDataArray;
            }
            data[count++] = value;
            HeapifyUp(count - 1);
        }

        public int Pop()
        {
            int poppedData = -1;
            if (count > 0)
            {
                poppedData = data[0];
                data[0] = data[count - 1];
                count--;
                HeapifyDown(0);
            }
            return poppedData;
        }

        private void HeapifyDown(int index)
        {
            int largest = index;
            int left = 2 * index + 1;
            int right = left + 1;
            
            if (left < count && data[left] > data[largest]) largest = left;
            if (right < count && data[right] > data[largest]) largest = right;

            if(largest != index)
            {
                int temp = data[index];
                data[index] = data[largest];
                data[largest] = temp;
                HeapifyDown(largest);
            }
        }

        private void HeapifyUp(int index)
        {
            int parentIndex = (index - 1) / 2;
            if(parentIndex >= 0 && parentIndex < count && data[parentIndex] < data[index])
            {
                int temp = data[parentIndex];
                data[parentIndex] = data[index];
                data[index] = temp;
                HeapifyUp(parentIndex);
            }
        }

        private void BuildHeap()
        {
            for(int i = count / 2; i >= 0; i--)
            {
                HeapifyDown(i);
            }
        }
    }
}
