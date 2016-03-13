using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.LinkedList;
using System.Collections.Generic;
using FluentAssertions;

namespace DsalTest.LinkedList
{
    [TestClass]
    public class RemoveNthFromLastFromLinkedListSpec
    {
        [TestMethod]
        public void Remove1stFromLastShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
             
            linkedList
                .AddItems(new int[] { 5, 7, 10 })
                .RemoveNthFromLast(1)
                .ToList()
                .Should().BeEquivalentTo(5, 7);
        }

        [TestMethod]
        public void Remove2ndFromLastShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();
            linkedList
                .AddItems(new int[] { 5, 7, 10, 12 })
                .RemoveNthFromLast(2)
                .ToList()
                .Should().BeEquivalentTo(5, 7, 12);
        }

        [TestMethod]
        public void Remove4thNodeFromLastIn4LengthLinkedListShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();

            linkedList
                .AddItems(new int[] { 5, 7, 10, 12 })
                .RemoveNthFromLast(4)
                .ToList()
                .Should().BeEquivalentTo(7, 10, 12);
        }
    }
}
