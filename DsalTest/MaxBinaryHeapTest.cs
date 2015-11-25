using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal;
using FluentAssertions;

namespace DsalTest
{
    [TestClass]
    public class MaxBinaryHeapTest
    {
        [TestMethod]
        public void BuildHeap_Pop_VeifyIfMax()
        {
            MaxBinaryHeap maxHeap = new MaxBinaryHeap(new int[] {2,8,7,1,6 });

            maxHeap.Pop().Should().Be(8);
        }

        [TestMethod]
        public void BuildHeap_Pop_Twice_VeifyIfMax()
        {
            MaxBinaryHeap maxHeap = new MaxBinaryHeap(new int[] { 2, 8, 7, 1, 6 });

            maxHeap.Pop().Should().Be(8);
            maxHeap.Pop().Should().Be(7);
        }

        [TestMethod]
        public void BuildHeap_Push_Larger_Value_VeifyIfMax()
        {
            MaxBinaryHeap maxHeap = new MaxBinaryHeap(new int[] { 2, 8, 7, 1, 6 });
            maxHeap.Push(50);
            maxHeap.Pop().Should().Be(50);
            
        }

        [TestMethod]
        public void BuildHeap_Push_Pop_Multiple_Value_VeifyIfMax()
        {
            MaxBinaryHeap maxHeap = new MaxBinaryHeap(new int[] { 2, 8, 7, 1, 6 });
            maxHeap.Push(50);
            maxHeap.Push(40);
            maxHeap.Push(70);
            maxHeap.Pop();
            maxHeap.Pop();
            maxHeap.Pop().Should().Be(40);

        }
    }
}
