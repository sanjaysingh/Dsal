using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public static class ToListExtension 
    {
        public static List<int> ToList(this DsalLinkedList linkedList)
        {
            LinkedListNode currNode = linkedList.Head;
            List<int> resultList = new List<int>();
            while (currNode != null)
            {
                resultList.Add(currNode.Data);
                currNode = currNode.Next;
            }

            return resultList;
        }
    }
}
