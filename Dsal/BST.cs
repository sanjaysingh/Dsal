using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal
{
    public class BST
    {
        private BSTNode root;

        public void VisitPostorderNonrecursive(Action<int> callback)
        {
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            BSTNode visitingNode = root;
            Stack<BSTNode> visitStack = new Stack<BSTNode>();
            BSTNode lastVisitedNode = null;
            while (visitStack.Count > 0 || visitingNode != null)
            {
                if (visitingNode != null)
                {
                    visitStack.Push(visitingNode);
                    visitingNode = visitingNode.Left;
                }
                else
                {
                    BSTNode currNode = visitStack.Peek();
                    if (currNode.Right != null && currNode.Right != lastVisitedNode)
                    {
                        visitingNode = currNode.Right;
                    }
                    else 
                    {
                        callback(currNode.Data);
                        lastVisitedNode = visitStack.Pop();
                    }
                }
            }
        }

        public void VisitInorderNonrecursive(Action<int> callback)
        {
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            BSTNode visitingNode = root;
            Stack<BSTNode> visitStack = new Stack<BSTNode>();

            while (visitStack.Count > 0 || visitingNode != null)
            {
                if (visitingNode != null)
                {
                    visitStack.Push(visitingNode);
                    visitingNode = visitingNode.Left;
                }
                else
                {
                    BSTNode currNode = visitStack.Pop();
                    callback(currNode.Data);
                    visitingNode = currNode.Right;
                }
            }
        }

        public void VisitPreorderNonrecursive(Action<int> callback)
        {
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            BSTNode visitingNode = root;
            Stack<BSTNode> visitStack = new Stack<BSTNode>();

            while (visitStack.Count > 0 || visitingNode != null)
            {
                if (visitingNode != null)
                {
                    callback(visitingNode.Data);
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

        public void VisitInorderRecursive(Action<int> callback)
        {
            VisitInorderRecursive(root, callback);
        }

        private void VisitInorderRecursive(BSTNode nodeToVisit, Action<int> callback)
        {
            if (nodeToVisit == null) return;
            VisitInorderRecursive(nodeToVisit.Left, callback);
            callback(nodeToVisit.Data);
            VisitInorderRecursive(nodeToVisit.Right, callback);
        }

        public void VisitPreorderRecursive(Action<int> callback)
        {
            VisitPreorderRecursive(root, callback);
        }
        private void VisitPreorderRecursive(BSTNode nodeToVisit, Action<int> callback)
        {
            if (nodeToVisit == null) return;
            callback(nodeToVisit.Data);
            VisitPreorderRecursive(nodeToVisit.Left, callback);
            VisitPreorderRecursive(nodeToVisit.Right, callback);
        }

        public void VisitPostorderRecursive(Action<int> callback)
        {
            VisitPostorderRecursive(root, callback);
        }
        private void VisitPostorderRecursive(BSTNode nodeToVisit, Action<int> callback)
        {
            if (nodeToVisit == null) return;

            VisitPostorderRecursive(nodeToVisit.Left, callback);
            VisitPostorderRecursive(nodeToVisit.Right, callback);
            callback(nodeToVisit.Data);
        }
        public void Add(int value)
        {
            BSTNode nodeToAdd = new BSTNode() { Data = value };
            if (root == null)
            {
                root = nodeToAdd;
            }
            else
            {
                AddNode(nodeToAdd, root);
            }

        }
        private void AddNode(BSTNode nodeToAdd, BSTNode addToNode)
        {
            if (nodeToAdd.Data < addToNode.Data)
            {
                if (addToNode.Left == null)
                {
                    addToNode.Left = nodeToAdd;
                }
                else AddNode(nodeToAdd, addToNode.Left);

            }
            else
            {
                if (addToNode.Right == null)
                {
                    addToNode.Right = nodeToAdd;
                }
                else
                {
                    AddNode(nodeToAdd, addToNode.Right);
                }
            }
        }
    }
}
