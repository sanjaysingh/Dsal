using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.LinkedList;
using System.Collections.Generic;
using FluentAssertions;

namespace DsalTest.LinkedList
{
    [TestClass]
    public class DeleteDuplicatesFromLinkedListSpec
    {
        [TestMethod]
        public void DeletingDuplicatesShouldGetRidOffAlltheDuplicates()
        {
            DsalLinkedList linkedList = new DsalLinkedList();

            linkedList
                .AddItems(new int[] { 1, 2, 1, 3, 3, 5 })
                .DeleteDuplicates()
                .ToList()
                .Should().BeEquivalentTo(1, 2, 3, 5);
        }
    }
}
