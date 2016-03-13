using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.LinkedList;
using System.Collections.Generic;
using FluentAssertions;

namespace DsalTest.LinkedList
{
    [TestClass]
    public class ReversePrintSpec
    {
        [TestMethod]
        public void ReversePrint5ItemsLinkedListShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();

            linkedList
                .AddItems(new int[] { 5, 7, 10, 3, 9 })
                .ReversePrint()
                .Should().BeEquivalentTo(9, 3, 10, 7, 5);
        }
        [TestMethod]
        public void ReversePrintSingleItemLinkedListShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();

            linkedList
                .AddItems(new int[] { 5 })
                .ReversePrint()
                .Should().BeEquivalentTo(5);
        }
    }
}
