using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.BinarySearchTree;
using System.Collections.Generic;
using FluentAssertions;
namespace DsalTest.BinarySearchTree
{
    [TestClass]
    public class NonRecursivePostorderTraverseSpec
    {
        [TestMethod]
        public void NonRecursivePostorderTraverseShouldVisitNodesInCorrectOrder()
        {
            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            List<int> dataToInsert = new List<int>() { 3, 1, 2, 5, 4 };
            dataToInsert.ForEach(value => new AddAnItemToBinarySearchTreeRecursive(bst, value).Execute());

            List<int> visitedData = new List<int>();
            new NonRecursivePostorderTraverse(bst, visitedData).Execute();
            
            visitedData.Should().ContainInOrder(2, 1, 4, 5, 3);
        }
    }
}
