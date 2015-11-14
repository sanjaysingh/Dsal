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

        // 1--->2---->3--->4---->5
        //
        //
        public void RemoveNthFromLast(int n)
        {
            Node currNode = head;
            Node nthNode = null;
            Node nMinus1stNode = null;
            int currentNodeIndex = 1;
            while(currNode != null)
            {
                if(nthNode != null)
                {
                    nMinus1stNode = nthNode;
                    nthNode = nthNode.Next;
                }
                if(currentNodeIndex == n)
                {
                    nthNode = head;
                }
                currNode = currNode.Next;
                currentNodeIndex++;
            }

            RemoveNode(nthNode, nMinus1stNode);
            
        }

        // 1--->2--->3--->4
        // ====>
        // 4--->3---->2---->1
        public void Reverse()
        {
            Node currNode = head;
            Node prevNode = null;

            while(currNode != null)
            {
                var nextNode = currNode.Next;
                currNode.Next = prevNode;
                prevNode = currNode;
                currNode = nextNode;
            }
            tail = head;
            head = prevNode;
        }

        private void RemoveNode(Node nodeToRemove, Node prevNode)
        {
            if (nodeToRemove == null) return;

            if (prevNode == null)
            {
                head = nodeToRemove.Next;
                if (tail == nodeToRemove)
                {
                    tail = nodeToRemove.Next;
                }
            }
            else
            {
                prevNode.Next = nodeToRemove.Next;
                if (tail == nodeToRemove)
                {
                    tail = prevNode;
                }
            }
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
            RemoveNode(currentNode, prevNode);
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
