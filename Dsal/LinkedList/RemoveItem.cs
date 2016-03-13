using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public static class RemoveItemExtension 
    {
        public static DsalLinkedList RemoveItem(this DsalLinkedList linkedList, int item)
        {
            LinkedListNode currentNode = linkedList.Head;
            LinkedListNode prevNode = null;

            while (currentNode != null && currentNode.Data != item)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
            }
            if (currentNode != null)
            {
                linkedList.RemoveNode(currentNode, prevNode);
                linkedList.Count--;
            }

            return linkedList;
        }
    }
}
