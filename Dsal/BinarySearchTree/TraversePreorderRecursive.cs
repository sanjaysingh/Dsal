using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class TraversePreorderRecursiveExtension
    {
        public static List<int> TraversePreorderRecursive(this DsalBinarySearchTree bst)
        {
            List<int> traversedList = new List<int>();
            VisitPreorder(bst.Root, traversedList);
            return traversedList;
        }

        private static void VisitPreorder(DsalBinaryTreeNode nodeToVisit, List<int> traversedList)
        {
            if (nodeToVisit == null) return;
            traversedList.Add(nodeToVisit.Data);
            VisitPreorder(nodeToVisit.Left, traversedList);
            VisitPreorder(nodeToVisit.Right, traversedList);
        }
    }
}
