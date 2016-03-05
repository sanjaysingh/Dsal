using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.LinkedList;
using System.Collections.Generic;
using FluentAssertions;

namespace DsalTest
{
    [TestClass]
    public class RemoveNthFromLastFromLinkedListSpec
    {
        [TestMethod]
        public void Remove1stFromLastShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
            new AddItemToLinkedList(linkedList, new int[] { 5, 7, 10 }).Execute();

            new RemoveNthFromLastFromLinkedList(linkedList, 1).Execute();

            List<int> remainingItems = new List<int>();
            new ConvertToListFromLinkedList(linkedList, remainingItems).Execute();

            remainingItems.Should().BeEquivalentTo(5, 7);
        }

        [TestMethod]
        public void Remove2ndFromLastShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
            new AddItemToLinkedList(linkedList, new int[] { 5, 7, 10, 12 }).Execute();

            new RemoveNthFromLastFromLinkedList(linkedList, 2).Execute();

            List<int> remainingItems = new List<int>();
            new ConvertToListFromLinkedList(linkedList, remainingItems).Execute();

            remainingItems.Should().BeEquivalentTo(5, 7, 12);
        }

        [TestMethod]
        public void Remove4thNodeFromLastIn4LengthLinkedListShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
            new AddItemToLinkedList(linkedList, new int[] { 5, 7, 10, 12 }).Execute();

            new RemoveNthFromLastFromLinkedList(linkedList, 4).Execute();

            List<int> remainingItems = new List<int>();
            new ConvertToListFromLinkedList(linkedList, remainingItems).Execute();

            remainingItems.Should().BeEquivalentTo(7, 10, 12);
        }
        
    }
}
