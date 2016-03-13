using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.BinarySearchTree;
using System.Collections.Generic;
using FluentAssertions;
namespace DsalTest.BinarySearchTree
{
    [TestClass]
    public class RemoveItemSpec
    {
        [TestMethod]
        public void RemoveLeafNodeShouldSucceed()
        {
            //                      5
            //                  3
            //              2       4
            //          1
            
            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            bst
                .AddItems(new List<int>() { 5, 3, 2, 1, 4 })
                .RemoveItem(1)
                .TraverseInorderRecursive()
                .Should().ContainInOrder(2, 3, 4, 7);
        }

        [TestMethod]
        public void RemoveNodeWithOnlyLeftChildShouldSucceed()
        {
            //                      5
            //                  3
            //              2       4
            //          1

            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            bst
                .AddItems(new List<int>() { 5, 3, 2, 1, 4 })
                .RemoveItem(2)
                .TraverseInorderRecursive()
                .Should().ContainInOrder(1, 3, 4, 5);
        }

        [TestMethod]
        public void RemoveNodeWithBothChildrenShouldSucceed()
        {
            //                      5
            //                  3
            //              2       4
            //          1
            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            bst
                .AddItems(new List<int>() { 5, 3, 2, 1, 4 })
                .RemoveItem(3)
                .TraverseInorderRecursive()
                .Should().ContainInOrder(1, 2, 4, 5);
        }

        [TestMethod]
        public void RemoveNodeWithBothChildrenAndRightChildHavingALeftSubtreeShouldSucceed()
        {
            //                      7
            //                  3
            //              2       6
            //          1       4
            //                      5
            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            bst
                .AddItems(new List<int>() { 7, 3, 2, 6, 5, 1, 4 })
                .RemoveItem(3)
                .TraverseInorderRecursive()
                .Should().ContainInOrder(1, 2, 4, 5, 6, 7);
        }
    }
}
