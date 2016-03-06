using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public class RecursivePreorderTraverse : AlgorithmBase
    {
        DsalBinarySearchTree bst;
        private List<int> traversedList;

        public RecursivePreorderTraverse(DsalBinarySearchTree bst, List<int> traversedList)
        {
            this.bst = bst;
            this.traversedList = traversedList;
        }

        protected override void OnExecute()
        {
            VisitPreorderRecursive(this.bst.Root);
        }

        private void VisitPreorderRecursive(DsalBinaryTreeNode nodeToVisit)
        {
            if (nodeToVisit == null) return;
            this.traversedList.Add(nodeToVisit.Data);
            VisitPreorderRecursive(nodeToVisit.Left);
            VisitPreorderRecursive(nodeToVisit.Right);
        }
    }
}
