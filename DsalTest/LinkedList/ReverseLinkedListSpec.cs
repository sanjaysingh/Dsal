using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.LinkedList;
using System.Collections.Generic;
using FluentAssertions;

namespace DsalTest.LinkedList
{
    [TestClass]
    public class ReverseLinkedListSpec
    {
        [TestMethod]
        public void Reverse5ItemsLinkedListShouldSucceed()
        {
            DsalLinkedList linkedList = new DsalLinkedList();

            linkedList
                .AddItems(new int[] { 5, 7, 10, 3, 9 })
                .Reverse()
                .ToList()
                .Should().BeEquivalentTo(9, 3, 10, 7, 5);
        }
    }
}
