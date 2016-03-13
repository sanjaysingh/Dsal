using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class TraverseInorderRecursiveExtension 
    {
        public static List<int> TraverseInorderRecursive(this DsalBinarySearchTree bst)
        {
            List<int> traversedList = new List<int>();
            VisitInorder(bst.Root, traversedList);

            return traversedList;
        }
        
        private static void VisitInorder(DsalBinaryTreeNode nodeToVisit, List<int> traversedList)
        {
            if (nodeToVisit == null) return;
            VisitInorder(nodeToVisit.Left, traversedList);
            traversedList.Add(nodeToVisit.Data);
            VisitInorder(nodeToVisit.Right, traversedList);
        }
    }
}
