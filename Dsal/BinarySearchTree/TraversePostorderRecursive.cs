using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class TraversePostorderRecursiveExtension
    {
        public static List<int> TraversePostorderRecursive(this DsalBinarySearchTree bst)
        {
            List<int> traversedList = new List<int>();
            VisitPostorder(bst.Root, traversedList);

            return traversedList;
        }

        private static void VisitPostorder(DsalBinaryTreeNode nodeToVisit, List<int> traversedList)
        {
            if (nodeToVisit == null) return;
            VisitPostorder(nodeToVisit.Left, traversedList);
            VisitPostorder(nodeToVisit.Right, traversedList);
            traversedList.Add(nodeToVisit.Data);
        }
    }
}
