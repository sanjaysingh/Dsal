using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public static class ReversePrintExtension 
    {
        public static List<int> ReversePrint(this DsalLinkedList linkedList)
        {
            return ReversePrint(linkedList.Head);
        }

        private static List<int> ReversePrint(LinkedListNode node)
        {
            if (node == null)
            {
                return new List<int>();
            }
            var printedList = ReversePrint(node.Next);
            printedList.Add(node.Data);
            return printedList;
        }
    }
}
