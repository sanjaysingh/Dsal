using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal;
using Dsal.MaxBinaryHeap;
using FluentAssertions;

namespace DsalTest.MaxBinaryHeap
{
    [TestClass]
    public class PopItemFromMaxBinaryHeapSpec
    {
        [TestMethod]
        public void PopOnceShouldReturnTheMaximumValue()
        {
            new BstMaxBinaryHeap()
                .BuildFrom(new int[] { 2, 8, 7, 1, 6 })
                .Pop()
                .Should().Be(8);
        }

        [TestMethod]
        public void PopTwiceShouldReturnThe2ndLargestValue()
        {
            var heap = new BstMaxBinaryHeap();
            heap.BuildFrom(new int[] { 2, 8, 7, 1, 6 }).Pop();
            heap.Pop()
                .Should().Be(7);
        }
    }
}
