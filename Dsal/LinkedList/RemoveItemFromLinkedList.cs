using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public class RemoveItemFromLinkedList : AlgorithmBase
    {
        private DsalLinkedList linkedList;
        private int item;
        public RemoveItemFromLinkedList(DsalLinkedList linkedList, int item)
        {
            this.linkedList = linkedList;
            this.item = item;
        }

        protected override void OnExecute()
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
                new RemoveNodeFromLinkedList(linkedList, currentNode, prevNode).Execute();
                linkedList.Count--;
            }
        }
    }
}
