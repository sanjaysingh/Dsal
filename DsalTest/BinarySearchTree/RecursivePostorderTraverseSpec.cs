using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.BinarySearchTree;
using System.Collections.Generic;
using FluentAssertions;
namespace DsalTest.BinarySearchTree
{
    [TestClass]
    public class RecursivePostorderTraverseSpec
    {
        [TestMethod]
        public void RecursivePostorderTraverseShouldVisitNodesInCorrectOrder()
        {
            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            //                      5
            //                  3
            //              2       4
            //          1
            List<int> dataToInsert = new List<int>() { 5, 3, 2, 1, 4 };
            dataToInsert.ForEach(value => new AddAnItemToBinarySearchTreeRecursive(bst, value).Execute());

            List<int> visitedData = new List<int>();
            new RecursivePostorderTraverse(bst, visitedData).Execute();

            visitedData.Should().ContainInOrder(1, 2, 4, 3, 5);
        }
    }
}
