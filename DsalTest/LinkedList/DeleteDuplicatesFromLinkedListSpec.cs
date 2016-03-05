using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.LinkedList;
using System.Collections.Generic;
using FluentAssertions;

namespace DsalTest
{
    [TestClass]
    public class DeleteDuplicatesFromLinkedListSpec
    {
        [TestMethod]
        public void DeletingDuplicatesShouldGetRidOffAlltheDuplicates()
        {
            DsalLinkedList linkedList = new DsalLinkedList();

            new AddItemToLinkedList(linkedList, new int[] { 1, 2, 1, 3, 3, 5 }).Execute();

            new DeleteDuplicatesFromLinkedList(linkedList).Execute();

            List<int> remainingItems = new List<int>();
            new ConvertToListFromLinkedList(linkedList, remainingItems).Execute();

            remainingItems.Should().BeEquivalentTo(1, 2, 3, 5);
        }
    }
}
