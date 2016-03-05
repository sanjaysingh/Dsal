using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public class RemoveNthFromLastFromLinkedList : AlgorithmBase
    {
        private DsalLinkedList linkedList;
        private int n;
        public RemoveNthFromLastFromLinkedList(DsalLinkedList linkedList, int n)
        {
            this.linkedList = linkedList;
            this.n = n;
        }

        protected override void OnExecute()
        {
            Node currNode = linkedList.Head;
            Node nthNode = null;
            Node nMinus1stNode = null;
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

            new RemoveNodeFromLinkedList(linkedList, nthNode, nMinus1stNode).Execute();
        }
    }
}
