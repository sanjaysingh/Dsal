using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class TraversePreorderNonrecursiveExtension 
    {
        public static List<int> TraversePreorderNonrecursive(this DsalBinarySearchTree bst)
        {
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            var traversedList = new List<int>();
            DsalBinaryTreeNode visitingNode = bst.Root;
            Stack<DsalBinaryTreeNode> visitStack = new Stack<DsalBinaryTreeNode>();

            while (visitStack.Count > 0 || visitingNode != null)
            {
                if (visitingNode != null)
                {
                    traversedList.Add(visitingNode.Data);
                    if (visitingNode.Right != null)
                        visitStack.Push(visitingNode.Right);
                    visitingNode = visitingNode.Left;
                }
                else
                {
                    visitingNode = visitStack.Pop();
                }
            }

            return traversedList;
        }
    }
}
