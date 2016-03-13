using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public static class RemoveNodeExtension 
    {
        public static DsalLinkedList RemoveNode(this DsalLinkedList linkedList, LinkedListNode nodeToRemove, LinkedListNode prevNode)
        {
            if (nodeToRemove == null) return linkedList;

            if (prevNode == null)
            {
                linkedList.Head = nodeToRemove.Next;
                if (linkedList.Tail == nodeToRemove)
                {
                    linkedList.Tail = nodeToRemove.Next;
                }
            }
            else
            {
                prevNode.Next = nodeToRemove.Next;
                if (linkedList.Tail == nodeToRemove)
                {
                    linkedList.Tail = prevNode;
                }
            }

            return linkedList;
        }

    }
}
