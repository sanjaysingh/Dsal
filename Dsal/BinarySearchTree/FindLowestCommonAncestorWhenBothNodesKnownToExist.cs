using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class FindLowestCommonAncestorWhenBothNodesKnownToExistExtension
    {
        public static DsalBinaryTreeNode FindLowestCommonAncestorWhenBothNodesKnownToExist(this DsalBinarySearchTree bst, int firstValue, int secondValue)
        {

            //                          3
            //                  1               5
            //                      2       4       6   
            //                      
            //
            return FindLCA(bst.Root, firstValue, secondValue);

        }

        private static DsalBinaryTreeNode FindLCA(DsalBinaryTreeNode currNode, int firstValue, int secondValue)
        {
            if (currNode == null) return null;
            if (firstValue < currNode.Data && secondValue < currNode.Data) return FindLCA(currNode.Left, firstValue, secondValue);
            if (firstValue > currNode.Data && secondValue > currNode.Data) return FindLCA(currNode.Right, firstValue, secondValue);
            return currNode;
        }
    }
}
