using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.BinarySearchTree;
using System.Collections.Generic;
using FluentAssertions;
namespace DsalTest.BinarySearchTree
{
    [TestClass]
    public class FindLowestCommonAncestorWhenBothNodesKnownToExistSpec
    {
        [TestMethod]
        public void FindLcaWhenItIsOnTheFirstLeftShouldBeReturnedCorrectly()
        {
            //                      5
            //                  3
            //              2       4
            //          1
            
            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            bst
                .AddItems(new List<int>() { 5, 3, 2, 1, 4 })
                .FindLowestCommonAncestorWhenBothNodesKnownToExist(2, 4)
                .Data.Should().Be(3);
        }

        [TestMethod]
        public void FindLcaWhenItIsOnTheFirstRightShouldBeReturnedCorrectly()
        {
            //                      5
            //                  4       8
            //              1       7       9
            //          

            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            bst
                .AddItems(new List<int>() { 5, 4, 1, 8, 7, 9 })
                .FindLowestCommonAncestorWhenBothNodesKnownToExist(7, 9)
                .Data.Should().Be(8);
        }

        [TestMethod]
        public void FindLcaWhenItIsTheRootShouldBeReturnedCorrectly()
        {
            //                      5
            //                  4       8
            //              1       7       9
            //          

            DsalBinarySearchTree bst = new DsalBinarySearchTree();
            bst
                .AddItems(new List<int>() { 5, 4, 1, 8, 7, 9 })
                .FindLowestCommonAncestorWhenBothNodesKnownToExist(1, 9)
                .Data.Should().Be(5);
        }
    }
}
