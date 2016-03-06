using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public class NonRecursivePostorderTraverse : AlgorithmBase
    {
        DsalBinarySearchTree bst;
        private List<int> traversedList;

        public NonRecursivePostorderTraverse(DsalBinarySearchTree bst, List<int> traversedList)
        {
            this.bst = bst;
            this.traversedList = traversedList;
        }

        protected override void OnExecute()
        {
            VisitPostorderNonrecursive();
        }

        private void VisitPostorderNonrecursive()
        {
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            DsalBinaryTreeNode visitingNode = this.bst.Root;
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
                        this.traversedList.Add(currNode.Data);
                        lastVisitedNode = visitStack.Pop();
                    }
                }
            }
        }
    }
}
