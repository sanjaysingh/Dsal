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
        public void OneNodeVisitShouldSucceed()
        {
            LinkedList list = new LinkedList(new int[] { 5});
            
            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().HaveCount(1, "Because we put one item in the linked list");
        }

        [TestMethod]
        public void TwoNodeVisitShouldSucceed()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7 });

            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().HaveCount(2, "Because we put 2 item in the linked list");
        }

        [TestMethod]
        public void RemoveMiddleShouldSucceed()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7, 10 });

            list.Remove(7);
            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().HaveCount(2, "Because we added 3 and removed 1");
        }

        [TestMethod]
        public void RemoveFirstShouldSucceed()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7, 10 });

            list.Remove(5);
            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().HaveCount(2, "Because we added 3 and removed head");
        }

        [TestMethod]
        public void RemoveLastShouldSucceed()
        {
            LinkedList list = new LinkedList(new int[] { 5, 7, 10 });

            list.Remove(10);
            list.Add(11);
            list.Add(12);
            List<int> itemsVisited = new List<int>();
            list.Visit((temp) => itemsVisited.Add(temp));

            itemsVisited.Should().HaveCount(4, "Because we added 3, then removed last one and added 2 more.");
        }
    }
}
