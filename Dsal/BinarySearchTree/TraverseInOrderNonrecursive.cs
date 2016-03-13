using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class TraverseInOrderNonrecursiveExtension
    {
        public static List<int> TraverseInOrderNonrecursive(this DsalBinarySearchTree bst)
        {
            List<int> traversedList = new List<int>();

            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            DsalBinaryTreeNode visitingNode = bst.Root;
            Stack<DsalBinaryTreeNode> visitStack = new Stack<DsalBinaryTreeNode>();

            while (visitStack.Count > 0 || visitingNode != null)
            {
                if (visitingNode != null)
                {
                    visitStack.Push(visitingNode);
                    visitingNode = visitingNode.Left;
                }
                else
                {
                    DsalBinaryTreeNode currNode = visitStack.Pop();
                    traversedList.Add(currNode.Data);
                    visitingNode = currNode.Right;
                }
            }
            return traversedList;
        }

    }
}
