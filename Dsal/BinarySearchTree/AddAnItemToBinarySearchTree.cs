using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public class AddAnItemToBinarySearchTreeRecursive : AlgorithmBase
    {
        DsalBinarySearchTree bst;
        private int itemToAdd;

        public AddAnItemToBinarySearchTreeRecursive(DsalBinarySearchTree bst, int itemToAdd)
        {
            this.bst = bst;
            this.itemToAdd = itemToAdd;
        }

        protected override void OnExecute()
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
        }

        private void AddNode(DsalBinaryTreeNode nodeToAdd, DsalBinaryTreeNode addToNode)
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
