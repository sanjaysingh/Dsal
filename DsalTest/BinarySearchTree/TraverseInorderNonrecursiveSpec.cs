using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.BinarySearchTree;
using System.Collections.Generic;
using FluentAssertions;
namespace DsalTest.BinarySearchTree
{
    [TestClass]
    public class TraverseInorderNonrecursiveSpec
    {
        [TestMethod]
        public void NonRecursivePreorderTraverseShouldVisitNodesInCorrectOrder()
        {
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            bst
                .AddItems(new List<int>() { 3, 1, 2, 5, 4 })
                .TraverseInOrderNonrecursive()
                .Should().BeInAscendingOrder();
        }
    }
}
