using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public class RemoveItemFromBinarySearchTree : AlgorithmBase
    {
        DsalBinarySearchTree bst;
        private int itemToRemove;

        public RemoveItemFromBinarySearchTree(DsalBinarySearchTree bst, int itemToRemove)
        {
            this.bst = bst;
            this.itemToRemove = itemToRemove;
        }

        protected override void OnExecute()
        {
            RemoveItem();
        }

        public void RemoveItem()
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
            BinaryTreeNodeWithParent itemToRemoveNode = new BinaryTreeNodeWithParent();

            new FindItemInBinarySearchTree(this.bst, this.itemToRemove, itemToRemoveNode);

            if (itemToRemoveNode.Node == null) return;

            if (itemToRemoveNode.Node.Right == null)
            {
                if (itemToRemoveNode.Parent == null) this.bst.Root = itemToRemoveNode.Node.Left;
                else if (itemToRemoveNode.Parent.Left == itemToRemoveNode.Node) itemToRemoveNode.Parent.Left = itemToRemoveNode.Node.Left;
                else itemToRemoveNode.Parent.Right = itemToRemoveNode.Node.Left;
            }
            else
            {
                DsalBinaryTreeNode nodeToReplace = itemToRemoveNode.Node.Right;
                DsalBinaryTreeNode nodeToReplaceParent = itemToRemoveNode.Node;
                while (nodeToReplace.Left != null)
                {
                    nodeToReplaceParent = nodeToReplace;
                    nodeToReplace = nodeToReplace.Left;
                }
                itemToRemoveNode.Node.Data = nodeToReplace.Data;
                if (nodeToReplaceParent.Left == nodeToReplace) nodeToReplaceParent.Left = nodeToReplace.Right;
                else nodeToReplaceParent.Right = nodeToReplace.Right;
            }
        }
    }
}
