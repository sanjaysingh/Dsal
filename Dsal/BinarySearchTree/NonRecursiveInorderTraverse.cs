using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public class NonRecursiveInorderTraverse : AlgorithmBase
    {
        DsalBinarySearchTree bst;
        private List<int> traversedList;

        public NonRecursiveInorderTraverse(DsalBinarySearchTree bst, List<int> traversedList)
        {
            this.bst = bst;
            this.traversedList = traversedList;
        }

        protected override void OnExecute()
        {
            VisitInorderNonrecursive();
        }

        public void VisitInorderNonrecursive()
        {
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            DsalBinaryTreeNode visitingNode = this.bst.Root;
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
                    this.traversedList.Add(currNode.Data);
                    visitingNode = currNode.Right;
                }
            }
        }
    }
}
