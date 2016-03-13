using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.BinarySearchTree;
using System.Collections.Generic;
using FluentAssertions;
namespace DsalTest.BinarySearchTree
{
    [TestClass]
    public class TraverseInorderRecursiveSpec
    {
        [TestMethod]
        public void RecursiveInorderTraverseShouldVisitNodesInCorrectOrder()
        {
            //                      5
            //                  3
            //              2       4
            //          1
            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            bst
                .AddItems(new List<int>() { 5, 3, 2, 1, 4 })
                .TraverseInorderRecursive()
                .Should().BeInAscendingOrder();
        }
    }
}
