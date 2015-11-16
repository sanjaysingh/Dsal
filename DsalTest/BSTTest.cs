using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal;
using System.Linq;
using System.Collections.Generic;
using FluentAssertions;
namespace DsalTest
{
    [TestClass]
    public class BSTTest
    {
        [TestMethod]
        public void Add_5_Nodes_Verify_Nonrecursive_Postorder_Traversal()
        {
            BST bst = new BST();
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            List<int> dataToInsert = new List<int>() { 3, 1, 2, 5, 4 };
            dataToInsert.ForEach(value => bst.Add(value));

            List<int> visitedData = new List<int>();
            bst.VisitPostorderNonrecursive(value => visitedData.Add(value));

            visitedData.Should().BeEquivalentTo(2, 1, 4, 5, 3);

        }

        [TestMethod]
        public void Add_5_Nodes_Verify_Nonrecursive_Preorder_Traversal()
        {
            BST bst = new BST();
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            List<int> dataToInsert = new List<int>() { 3, 1, 2, 5, 4 };
            dataToInsert.ForEach(value => bst.Add(value));

            List<int> visitedData = new List<int>();
            bst.VisitPreorderNonrecursive(value => visitedData.Add(value));

            visitedData.Should().BeEquivalentTo(dataToInsert);

        }

        [TestMethod]
        public void Add_5_Nodes_Verify_Nonrecursive_Inorder_Traversal()
        {
            BST bst = new BST();
            //                          3
            //                  1               5
            //                      2       4          
            //                      
            //
            List<int> dataToInsert = new List<int>() { 3,1,2,5,4};
            dataToInsert.ForEach(value => bst.Add(value));

            List<int> visitedData = new List<int>();
            bst.VisitInorderNonrecursive(value => visitedData.Add(value));

            visitedData.Should().BeInAscendingOrder();

        }

        [TestMethod]
        public void Add_4_Nodes_Verify_Nonrecursive_Inorder_Traversal()
        {
            BST bst = new BST();
            //                          9
            //                      7    
            //                  5           
            //              3                  
            //
            List<int> dataToInsert = new List<int>() { 9,7 ,5, 3 };
            dataToInsert.ForEach(value => bst.Add(value));

            List<int> visitedData = new List<int>();
            bst.VisitInorderNonrecursive(value => visitedData.Add(value));

            visitedData.Should().BeInAscendingOrder();

        }

        [TestMethod]
        public void Add_5_Nodes_Verify_Recursive_Inorder_Traversal()
        {
            BST bst = new BST();
            //                      5
            //                  3
            //              2       4
            //          1
            List<int> dataToInsert = new List<int>() { 5,3,2,1,4};
            dataToInsert.ForEach(value => bst.Add(value));

            List<int> visitedData = new List<int>();
            bst.VisitInorderRecursive(value => visitedData.Add(value));

            visitedData.Should().BeInAscendingOrder();
            
        }
        [TestMethod]
        public void Add_5_Nodes_Verify_Recursive_Preorder_Traversal()
        {
            BST bst = new BST();
            //                      5
            //                  3
            //              2       4
            //          1
            List<int> dataToInsert = new List<int>() { 5, 3, 2, 1, 4 };
            dataToInsert.ForEach(value => bst.Add(value));

            List<int> visitedData = new List<int>();
            bst.VisitInorderRecursive(value => visitedData.Add(value));

            visitedData.Should().BeEquivalentTo(dataToInsert);
        }

        [TestMethod]
        public void Add_5_Nodes_Verify_Recursive_Postorder_Traversal()
        {
            BST bst = new BST();
            //                      5
            //                  3
            //              2       4
            //          1
            List<int> dataToInsert = new List<int>() { 5, 3, 2, 1, 4 };
            dataToInsert.ForEach(value => bst.Add(value));

            List<int> visitedData = new List<int>();
            bst.VisitInorderRecursive(value => visitedData.Add(value));

            visitedData.Should().BeEquivalentTo(1,2,4,3,5);

        }
    }
}
