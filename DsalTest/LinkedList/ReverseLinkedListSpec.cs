using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.LinkedList;
using System.Collections.Generic;
using FluentAssertions;

namespace DsalTest
{
    [TestClass]
    public class ReverseLinkedListSpec
    {
        [TestMethod]
        public void Reverse5ItemsLinkedListShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
            new AddItemToLinkedList(linkedList, new int[] { 5, 7, 10, 3, 9 }).Execute();

            new ReverseLinkedList(linkedList).Execute();

            List<int> remainingItems = new List<int>();
            new ConvertToListFromLinkedList(linkedList, remainingItems).Execute();

            remainingItems.Should().BeEquivalentTo(9, 3, 10, 7, 5);
        }

    }
}
