using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public class RecursiveInorderTraverse : AlgorithmBase
    {
        DsalBinarySearchTree bst;
        private List<int> traversedList;

        public RecursiveInorderTraverse(DsalBinarySearchTree bst, List<int> traversedList)
        {
            this.bst = bst;
            this.traversedList = traversedList;
        }

        protected override void OnExecute()
        {
            VisitInorderRecursive(this.bst.Root);
        }

        private void VisitInorderRecursive(DsalBinaryTreeNode nodeToVisit)
        {
            if (nodeToVisit == null) return;
            VisitInorderRecursive(nodeToVisit.Left);
            this.traversedList.Add(nodeToVisit.Data);
            VisitInorderRecursive(nodeToVisit.Right);
        }
    }
}
