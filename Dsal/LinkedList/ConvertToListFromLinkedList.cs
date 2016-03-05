using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.LinkedList
{
    public class ConvertToListFromLinkedList : AlgorithmBase
    {
        private DsalLinkedList linkedList;
        private List<int> resultList;
        public ConvertToListFromLinkedList(DsalLinkedList linkedList, List<int> resultList)
        {
            this.linkedList = linkedList;
            this.resultList = resultList;
            resultList.Clear();
        }

        protected override void OnExecute()
        {
            Node currNode = linkedList.Head;
            while (currNode != null)
            {
                resultList.Add(currNode.Data);
                currNode = currNode.Next;
            }
        }
    }
}
