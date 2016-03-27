using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dsal.String;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;

namespace DsalTest.String
{
    [TestClass]
    public class FindNpNPermutationsRecursiveTest
    {
        [TestMethod]
        public void FindNpNForStringOfLength1ShouldSucceed()
        {
            "A"
                .FindNpNPermutationsRecursive()
                .Should()
                .BeEquivalentTo("A");
        }

        [TestMethod]
        public void FindNpNForStringOfLength2ShouldSucceed()
        {
            "AB"
                .FindNpNPermutationsRecursive()
                .Should()
                .BeEquivalentTo("AB", "BA");
        }
        [TestMethod]
        public void FindNpNForStringOfLength3ShouldSucceed()
        {
            "ABC"
                .FindNpNPermutationsRecursive()
                .Should()
                .BeEquivalentTo("ABC", "ACB", "BAC", "BCA", "CAB", "CBA");
        }

        [TestMethod]
        public void FindNpNForStringOfLength4ShouldSucceed()
        {
            "ABCD"
                .FindNpNPermutationsRecursive()
                .Should()
                .BeEquivalentTo("ABCD", "ABDC", "ACBD", "ACDB", "ADBC", "ADCB", 
                                "BACD", "BADC", "BCAD", "BCDA", "BDAC", "BDCA",
                                "CABD", "CADB", "CBAD", "CBDA", "CDAB", "CDBA",
                                "DABC", "DACB", "DBAC", "DBCA", "DCAB", "DCBA");
        }
    }
}
