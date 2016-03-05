using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.LinkedList;
using System.Collections.Generic;
using FluentAssertions;

namespace DsalTest
{
    [TestClass]
    public class RemoveItemFromLinkedListSpec
    {
        [TestMethod]
        public void RemoveItemFromMiddleShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
            new AddItemToLinkedList(linkedList, new int[] { 5, 7, 10 }).Execute();

            new RemoveItemFromLinkedList(linkedList, 7).Execute();

            List<int> remainingItems = new List<int>();
            new ConvertToListFromLinkedList(linkedList, remainingItems).Execute();

            remainingItems.Should().BeEquivalentTo(5, 10);
        }

        [TestMethod]
        public void RemoveFirstItemShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
            new AddItemToLinkedList(linkedList, new int[] { 5, 7, 10 }).Execute();

            new RemoveItemFromLinkedList(linkedList, 5).Execute();

            List<int> remainingItems = new List<int>();
            new ConvertToListFromLinkedList(linkedList, remainingItems).Execute();

            remainingItems.Should().BeEquivalentTo(7, 10);
        }

        [TestMethod]
        public void RemoveLastItemShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
            new AddItemToLinkedList(linkedList, new int[] { 5, 7, 10 }).Execute();

            new RemoveItemFromLinkedList(linkedList, 10).Execute();

            List<int> remainingItems = new List<int>();
            new ConvertToListFromLinkedList(linkedList, remainingItems).Execute();

            remainingItems.Should().BeEquivalentTo(5, 7);
        }
    }
}
