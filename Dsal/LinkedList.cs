using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int count;

        public LinkedList(IEnumerable<int> contents)
        {
            foreach(var item in contents)
            {
                Add(item);
            }
        }

        public void Add(int item)
        {
            var newNode = new Node() { Data = item };
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            count++;
        }

        public void Remove(int item)
        {
            Node currentNode = head;
            Node prevNode = null;

            while(currentNode != null && currentNode.Data != item)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
            }
            if (currentNode == null) throw new KeyNotFoundException("Given item was not found");
            if(prevNode == null)
            {
                head = currentNode.Next;
                if(tail == currentNode)
                {
                    tail = currentNode.Next;
                }
            }
            else
            {
                prevNode.Next = currentNode.Next;
                if (tail == currentNode)
                {
                    tail = prevNode;
                }
            }
            count--;
        }

        public void Visit(Action<int> callback)
        {
            Node currNode = head;
            while (currNode != null)
            {
                callback(currNode.Data);
                currNode = currNode.Next;
            }
        }

        public void Clear()
        {
            head = tail = null;
        }
    }
}
