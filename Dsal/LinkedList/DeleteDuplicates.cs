using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public static class DeleteDuplicatesExtension 
    {
        public static DsalLinkedList DeleteDuplicates(this DsalLinkedList linkedList)
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

            return linkedList;
        }
    }
}
