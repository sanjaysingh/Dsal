using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class AddItemExtension 
    {
        public static DsalBinarySearchTree AddItem(this DsalBinarySearchTree bst, int itemToAdd)
        {
            DsalBinaryTreeNode nodeToAdd = new DsalBinaryTreeNode() { Data = itemToAdd };
            if (bst.Root == null)
            {
                bst.Root = nodeToAdd;
            }
            else
            {
                AddNode(nodeToAdd, bst.Root);
            }
            return bst;
        }

        private static void AddNode(DsalBinaryTreeNode nodeToAdd, DsalBinaryTreeNode addToNode)
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
