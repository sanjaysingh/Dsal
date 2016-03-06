using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public class RemoveNodeFromLinkedList : AlgorithmBase
    {
        private DsalLinkedList linkedList;
        private LinkedListNode nodeToRemove;
        private LinkedListNode prevNode;
        public RemoveNodeFromLinkedList(DsalLinkedList linkedList, LinkedListNode nodeToRemove, LinkedListNode prevNode)
        {
            this.linkedList = linkedList;
            this.nodeToRemove = nodeToRemove;
            this.prevNode = prevNode;
        }

        protected override void OnExecute()
        {
            if (nodeToRemove == null) return;

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
        }

    }
}
