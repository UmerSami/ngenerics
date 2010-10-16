﻿using System;
using System.Collections.Generic;
using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.SetTests
{
    [TestFixture]
    public class CopyTo
    {

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExcepionNullArray()
        {
            var pascalSet = new PascalSet(20);
            pascalSet.CopyTo(null, 0);
        }

        [Test]
        public void Simple()
        {
            var pascalSet = new PascalSet(10, new[] { 1, 2, 5, 6 });

            var array = new int[4];
            pascalSet.CopyTo(array, 0);

            var list = new List<int>(array);

            Assert.IsTrue(list.Contains(1));
            Assert.IsTrue(list.Contains(2));
            Assert.IsTrue(list.Contains(5));
            Assert.IsTrue(list.Contains(6));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionInvalid1()
        {
            var pascalSet = new PascalSet(10, new[] { 1, 2, 5, 6 });

            var array = new int[3];
            pascalSet.CopyTo(array, 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionInvalid2()
        {
            var pascalSet = new PascalSet(10, new[] { 1, 2, 5, 6 });

            var array = new int[4];
            pascalSet.CopyTo(array, 1);
        }

    }
}