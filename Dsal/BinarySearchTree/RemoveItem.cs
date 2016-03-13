using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class RemoveItemExtension 
    {
        public static DsalBinarySearchTree RemoveItem(this DsalBinarySearchTree bst, int itemToRemove)
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
            var itemToRemoveNode = bst.FindItem(itemToRemove);

            if (itemToRemoveNode.Node == null) return bst;

            if (itemToRemoveNode.Node.Right == null)
            {
                if (itemToRemoveNode.Parent == null) bst.Root = itemToRemoveNode.Node.Left;
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

            return bst;
        }
    }
}
