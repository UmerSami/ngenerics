﻿using System.Collections.Generic;
using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.GraphTests
{
    [TestFixture]
    public class Add : GraphTest
    {
        [Test]
        public void Interface()
        {
            var graph = new Graph<int>(true);
            ((ICollection<int>)graph).Add(4);
            Assert.AreEqual(graph.Vertices.Count, 1);
        }
    }
}