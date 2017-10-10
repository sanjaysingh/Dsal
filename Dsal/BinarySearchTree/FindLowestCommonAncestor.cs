using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class FindLowestCommonAncestorExtension
    {
        public static DsalBinaryTreeNode FindLowestCommonAncestor(this DsalBinarySearchTree bst, int firstValue, int secondValue)
        {

            //                          3
            //                  1               5
            //                      2       4       6   
            //                      
            //
            DsalBinaryTreeNode lca = null;
            var firstPath = FindPath(bst, firstValue);
            var secondPath = FindPath(bst, secondValue);
            for(int i=0;i<firstPath.Count() && i < secondPath.Count(); i++)
            {
                if (firstPath[i] == secondPath[i]) lca = firstPath[i];
                else break;
            }
            return lca;
        }

        private static List<DsalBinaryTreeNode> FindPath(DsalBinarySearchTree bst, int value)
        {
            List<DsalBinaryTreeNode> firstPath = new List<DsalBinaryTreeNode>();
            var currNode = bst.Root;
            while (currNode != null)
            {
                firstPath.Add(currNode);
                if (value < currNode.Data) { currNode = currNode.Left; }
                else if (value > currNode.Data) { currNode = currNode.Right; }
                else return firstPath;
            }

            return new List<DsalBinaryTreeNode>();
        }
    }
}
