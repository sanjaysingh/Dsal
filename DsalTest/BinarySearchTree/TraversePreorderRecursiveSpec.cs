using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.BinarySearchTree;
using System.Collections.Generic;
using FluentAssertions;
namespace DsalTest.BinarySearchTree
{
    [TestClass]
    public class TraversePreorderRecursiveSpec
    {
        [TestMethod]
        public void RecursivePreorderTraverseShouldVisitNodesInCorrectOrder()
        {
            //                      5
            //                  3
            //              2       4
            //          1
            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            bst
                .AddItems(new List<int>() { 5, 3, 2, 1, 4 })
                .TraversePreorderRecursive()
                .Should().ContainInOrder(5, 3, 2, 1, 4);
        }
    }
}
