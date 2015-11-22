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

        #region Find

        public void Find(int value, ref BSTNode valueNode, ref BSTNode valueParentNode)
        {
            Find(value, root, null, ref valueNode, ref valueParentNode);
        }

        private void Find(int value, BSTNode searchingNode, BSTNode searchingNodeParent, ref BSTNode valueNode, ref BSTNode valueParentNode)
        {
            if (searchingNode == null) return;
            if (searchingNode.Data == value)
            {
                valueNode = searchingNode;
                valueParentNode = searchingNodeParent;
            }
            else if (value < searchingNode.Data)
            {
                Find(value, searchingNode.Left, searchingNode, ref valueNode, ref valueParentNode);
            }
            else
            {
                Find(value, searchingNode.Right, searchingNode, ref valueNode, ref valueParentNode);
            }
        }

        #endregion

        #region Remove node

        public void Remove(int valueToRemove)
        {
            // 1. remove 6.         8
            //                  6
            //
            // 2. Remove 6          8
            //                  6
            //              2       7
            //
            // 
            // 3. Remove 6.         9
            //                  6
            //              2       8
            //                  7
            //
            BSTNode valueNode = null, valueParentNode = null;
            Find(valueToRemove, ref valueNode, ref valueParentNode);

            if (valueNode == null) return;

            if (valueNode.Right == null)
            {
                if (valueParentNode == null) root = valueNode.Left;
                else if (valueParentNode.Left == valueNode) valueParentNode.Left = valueNode.Left;
                else valueParentNode.Right = valueNode.Left;
            }
            else
            {
                BSTNode nodeToReplace = valueNode.Right;
                BSTNode nodeToReplaceParent = valueNode;
                while (nodeToReplace.Left != null)
                {
                    nodeToReplaceParent = nodeToReplace;
                    nodeToReplace = nodeToReplace.Left;
                }
                valueNode.Data = nodeToReplace.Data;
                if (nodeToReplaceParent.Left == nodeToReplace) nodeToReplaceParent.Left = nodeToReplace.Right;
                else nodeToReplaceParent.Right = nodeToReplace.Right;
            }
        }

        #endregion

        #region Visitors

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

        #endregion

        #region Add node

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

        #endregion
    }
}
