using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.BinarySearchTree;
using System.Collections.Generic;
using FluentAssertions;
namespace DsalTest.BinarySearchTree
{
    [TestClass]
    public class TraversePostorderNonrecursiveSpec
    {
        [TestMethod]
        public void NonRecursivePostorderTraverseShouldVisitNodesInCorrectOrder()
        {
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            bst
                .AddItems(new List<int>() { 3, 1, 2, 5, 4 })
                .TraversePostorderNonrecursive()
                .Should().ContainInOrder(2, 1, 4, 5, 3);
        }
    }
}
