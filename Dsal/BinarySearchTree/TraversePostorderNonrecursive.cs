using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class TraversePostorderNonrecursiveExtension 
    {
        public static List<int> TraversePostorderNonrecursive(this DsalBinarySearchTree bst)
        {
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            var traversedList = new List<int>();
            DsalBinaryTreeNode visitingNode = bst.Root;
            Stack<DsalBinaryTreeNode> visitStack = new Stack<DsalBinaryTreeNode>();
            DsalBinaryTreeNode lastVisitedNode = null;
            while (visitStack.Count > 0 || visitingNode != null)
            {
                if (visitingNode != null)
                {
                    visitStack.Push(visitingNode);
                    visitingNode = visitingNode.Left;
                }
                else
                {
                    DsalBinaryTreeNode currNode = visitStack.Peek();
                    if (currNode.Right != null && currNode.Right != lastVisitedNode)
                    {
                        visitingNode = currNode.Right;
                    }
                    else
                    {
                        traversedList.Add(currNode.Data);
                        lastVisitedNode = visitStack.Pop();
                    }
                }
            }

            return traversedList;
        }
    }
}
