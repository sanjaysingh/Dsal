using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public static class AddItemExtension
    {
        public static DsalLinkedList AddItems(this DsalLinkedList linkedList, IEnumerable<int> items)
        {
            foreach (var item in items)
            {
                var newNode = new LinkedListNode() { Data = item };

                if (linkedList.Head == null)
                {
                    linkedList.Head = linkedList.Tail = newNode;
                }
                else
                {
                    linkedList.Tail.Next = newNode;
                    linkedList.Tail = newNode;
                }
                linkedList.Count++;
            }
            return linkedList;
        }
    }
}
