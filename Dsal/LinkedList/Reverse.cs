using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public static class ReverseExtension 
    {
        public static DsalLinkedList Reverse(this DsalLinkedList linkedList)
        {
            LinkedListNode currNode = linkedList.Head;
            LinkedListNode prevNode = null;

            while (currNode != null)
            {
                var nextNode = currNode.Next;
                currNode.Next = prevNode;
                prevNode = currNode;
                currNode = nextNode;
            }
            linkedList.Tail = linkedList.Head;
            linkedList.Head = prevNode;

            return linkedList;
        }
    }
}
