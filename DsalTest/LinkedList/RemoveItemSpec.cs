using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.LinkedList;
using System.Collections.Generic;
using FluentAssertions;

namespace DsalTest.LinkedList
{
    [TestClass]
    public class RemoveItemFromLinkedListSpec
    {
        [TestMethod]
        public void RemoveItemFromMiddleShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
            linkedList
                .AddItems(new int[] { 5, 7, 10 })
                .RemoveItem(7)
                .ToList()
                .Should().BeEquivalentTo(5, 10);
        }

        [TestMethod]
        public void RemoveFirstItemShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
            linkedList
                .AddItems(new int[] { 5, 7, 10 })
                .RemoveItem(5)
                .ToList()
                .Should().BeEquivalentTo(7, 10);
        }

        [TestMethod]
        public void RemoveLastItemShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
            linkedList
                .AddItems(new int[] { 5, 7, 10 })
                .RemoveItem(10)
                .ToList()
                .Should().BeEquivalentTo(5, 7);
        }
    }
}
