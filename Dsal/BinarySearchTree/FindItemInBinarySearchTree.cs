using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public class FindItemInBinarySearchTree : AlgorithmBase
    {
        DsalBinarySearchTree bst;
        private int itemToFind;
        private BinaryTreeNodeWithParent searchResultNode;

        public FindItemInBinarySearchTree(DsalBinarySearchTree bst, int itemToFind, BinaryTreeNodeWithParent searchResultNode)
        {
            this.bst = bst;
            this.itemToFind = itemToFind;
            this.searchResultNode = searchResultNode;
        }

        protected override void OnExecute()
        {
            Find(this.itemToFind, this.bst.Root, null);
        }

        private void Find(int value, DsalBinaryTreeNode searchingNode, DsalBinaryTreeNode searchingNodeParent)
        {
            if (searchingNode == null) return;
            if (searchingNode.Data == value)
            {
                searchResultNode.Node = searchingNode;
                searchResultNode.Parent = searchingNodeParent;
            }
            else if (value < searchingNode.Data)
            {
                Find(value, searchingNode.Left, searchingNode);
            }
            else
            {
                Find(value, searchingNode.Right, searchingNode);
            }
        }
    }
}
