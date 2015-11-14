using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal;
using System.Collections.Generic;
using FluentAssertions;

namespace DsalTest
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void Visit_One_Node_List_Shoule_Be_Success()
        {
            LinkedList list = new LinkedList(new int[] { 5});
            
            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().HaveCount(1, "Because we put one item in the linked list");
        }

        [TestMethod]
        public void Visit_Two_Node_List_Should_Be_Success()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7 });

            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().HaveCount(2, "Because we put 2 item in the linked list");
        }

        [TestMethod]
        public void Remove_Middle_Node_Should_Be_Success()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7, 10 });

            list.Remove(7);
            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().HaveCount(2, "Because we added 3 and removed 1");
        }

        [TestMethod]
        public void Remove_First_Node_Should_Be_Succes()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7, 10 });

            list.Remove(5);
            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().HaveCount(2, "Because we added 3 and removed head");
        }

        [TestMethod]
        public void Remove_LastNode_Should_Be_Success()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7, 10 });

            list.Remove(10);
            list.Add(11);
            list.Add(12);
            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().HaveCount(4, "Because we added 3, then removed last one and added 2 more.");
        }

        [TestMethod]
        public void Remove_2ndNodeFromLast_3NodeList_ShouldBeSuccess()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7, 10 });

            list.RemoveNthFromLast(2);
            
            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().Equal(new int[] { 5,10}, "Because we removed 2nd elment from last for 3 elements list");
        }

        [TestMethod]
        public void Remove_1stNodeFromLast_3NodeList_ShouldBeSuccess()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7, 10 });

            list.RemoveNthFromLast(1);

            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().Equal(new int[] { 5, 7 }, "Because we removed 1st elment from last for 3 elements list");
        }

        [TestMethod]
        public void Remove_3rdNodeFromLast_3NodeList_ShouldBeSuccess()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7, 10 });

            list.RemoveNthFromLast(3);

            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().Equal(new int[] {  7, 10 }, "Because we removed 3rd elment from last for 3 elements list");
        }

        [TestMethod]
        public void Reverse_3NodeList_ShouldBeSuccess()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7, 10 });

            list.Reverse();

            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().Equal(new int[] { 10,7,5 }, "Because we reversed the list.");
        }

        [TestMethod]
        public void Reverse_5NodeList_Then_Remove_FirstAndLast_ShouldBeSuccess()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7, 10, 12, 13 });

            list.Reverse();
            list.Remove(13);
            list.Remove(5);
            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().Equal(new int[] { 12,10,7 }, "Because we reversed the list and then removed 1st and last items.");
        }
    }
}
