using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public static class RemoveNthFromLastExtension 
    {
        public static DsalLinkedList RemoveNthFromLast(this DsalLinkedList linkedList, int n)
        {
            LinkedListNode currNode = linkedList.Head;
            LinkedListNode nthNode = null;
            LinkedListNode nMinus1stNode = null;
            int currentNodeIndex = 1;
            while (currNode != null)
            {
                if (nthNode != null)
                {
                    nMinus1stNode = nthNode;
                    nthNode = nthNode.Next;
                }
                if (currentNodeIndex == n)
                {
                    nthNode = linkedList.Head;
                }
                currNode = currNode.Next;
                currentNodeIndex++;
            }
            return linkedList.RemoveNode(nthNode, nMinus1stNode);
        }
    }
}
