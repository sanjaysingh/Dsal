using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public class ReverseLinkedList : AlgorithmBase
    {
        private DsalLinkedList linkedList;
        
        public ReverseLinkedList(DsalLinkedList linkedList)
        {
            this.linkedList = linkedList;
        }

        protected override void OnExecute()
        {
            Node currNode = linkedList.Head;
            Node prevNode = null;

            while (currNode != null)
            {
                var nextNode = currNode.Next;
                currNode.Next = prevNode;
                prevNode = currNode;
                currNode = nextNode;
            }
            linkedList.Tail = linkedList.Head;
            linkedList.Head = prevNode;
        }
    }
}
