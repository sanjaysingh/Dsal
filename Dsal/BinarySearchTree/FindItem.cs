using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.BinarySearchTree
{
    public static class FindItemExtension 
    {
        public static BinaryTreeNodeWithParent FindItem(this DsalBinarySearchTree bst, int itemToFind)
        {
            return Find(itemToFind, bst.Root, null);
        }

        private static BinaryTreeNodeWithParent Find(int value, 
                                                        DsalBinaryTreeNode searchingNode, 
                                                        DsalBinaryTreeNode searchingNodeParent)
        {
            if (searchingNode == null) return new BinaryTreeNodeWithParent();
            if (searchingNode.Data == value)
            {
                var searchResultNode = new BinaryTreeNodeWithParent();
                searchResultNode.Node = searchingNode;
                searchResultNode.Parent = searchingNodeParent;
                return searchResultNode;
            }
            else if (value < searchingNode.Data)
            {
                return Find(value, searchingNode.Left, searchingNode);
            }
            else
            {
                return Find(value, searchingNode.Right, searchingNode);
            }
        }
    }
}
