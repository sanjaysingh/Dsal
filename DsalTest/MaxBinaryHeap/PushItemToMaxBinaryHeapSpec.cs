using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal;
using Dsal.MaxBinaryHeap;
using FluentAssertions;

namespace DsalTest.MaxBinaryHeap
{
    [TestClass]
    public class PushItemToMaxBinaryHeapSpec
    {
        [TestMethod]
        public void PushingLargerThanAnyInTheHeapShouldPushItToTop()
        {
            new BstMaxBinaryHeap()
                .BuildFrom(new int[] { 2, 8, 7, 1, 6 })
                .Push(50)
                .Pop()
                .Should().Be(50);
        }

        [TestMethod]
        public void PushingSmallerValueThanLargestInTheHeapShouldNotAffectTheTopItem()
        {
            new BstMaxBinaryHeap()
                .BuildFrom(new int[] { 2, 8, 7, 1, 6 })
                .Push(5)
                .Pop()
                .Should().Be(8);
        }
    }
}
