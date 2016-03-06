using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public class RecursivePostorderTraverse : AlgorithmBase
    {
        DsalBinarySearchTree bst;
        private List<int> traversedList;

        public RecursivePostorderTraverse(DsalBinarySearchTree bst, List<int> traversedList)
        {
            this.bst = bst;
            this.traversedList = traversedList;
        }

        protected override void OnExecute()
        {
            VisitPostorderRecursive(this.bst.Root);
        }

        private void VisitPostorderRecursive(DsalBinaryTreeNode nodeToVisit)
        {
            if (nodeToVisit == null) return;

            VisitPostorderRecursive(nodeToVisit.Left);
            VisitPostorderRecursive(nodeToVisit.Right);
            this.traversedList.Add(nodeToVisit.Data);
        }
    }
}
