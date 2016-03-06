using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public class DeleteDuplicatesFromLinkedList : AlgorithmBase
    {
        private DsalLinkedList linkedList;

        public DeleteDuplicatesFromLinkedList(DsalLinkedList linkedList)
        {
            this.linkedList = linkedList;
        }

        protected override void OnExecute()
        {
            LinkedListNode currNode = linkedList.Head;
            LinkedListNode previous = null;
            Dictionary<int, bool> valuesHash = new Dictionary<int, bool>();
            //
            // 1-->2-->1-->3
            //
            while (currNode != null)
            {
                if (valuesHash.ContainsKey(currNode.Data))
                {
                    previous.Next = currNode.Next;
                }
                else
                {
                    valuesHash.Add(currNode.Data, true);
                    previous = currNode;
                }
                currNode = currNode.Next;
            }
        }
    }
}
