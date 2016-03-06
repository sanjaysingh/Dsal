using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public class NonRecursivePreorderTraverse : AlgorithmBase
    {
        DsalBinarySearchTree bst;
        private List<int> traversedList;

        public NonRecursivePreorderTraverse(DsalBinarySearchTree bst, List<int> traversedList)
        {
            this.bst = bst;
            this.traversedList = traversedList;
        }

        protected override void OnExecute()
        {
            VisitPreorderNonrecursive();
        }

        private void VisitPreorderNonrecursive()
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
                    this.traversedList.Add(visitingNode.Data);
                    if (visitingNode.Right != null)
                        visitStack.Push(visitingNode.Right);
                    visitingNode = visitingNode.Left;
                }
                else
                {
                    visitingNode = visitStack.Pop();
                }
            }
        }
    }
}
