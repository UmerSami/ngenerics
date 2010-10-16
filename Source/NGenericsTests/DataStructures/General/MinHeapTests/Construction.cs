﻿using System.Collections.Generic;
using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.MinHeapTests
{
    [TestFixture]
    public class Construction : MinHeapTest
    {
        [Test]
        public void Simple()
        {
            var heap = new Heap<int>(HeapType.Minimum);

            Assert.AreEqual(heap.Type, HeapType.Minimum);
            Assert.AreEqual(heap.Count, 0);
            Assert.IsTrue(heap.IsEmpty);

            heap = new Heap<int>(HeapType.Minimum, Comparer<int>.Default);

            Assert.AreEqual(heap.Type, HeapType.Minimum);
            Assert.AreEqual(heap.Count, 0);
            Assert.IsTrue(heap.IsEmpty);

            heap = new Heap<int>(HeapType.Minimum, 50);

            Assert.AreEqual(heap.Type, HeapType.Minimum);
            Assert.AreEqual(heap.Count, 0);
            Assert.IsTrue(heap.IsEmpty);

            heap = new Heap<int>(HeapType.Minimum, 50, Comparer<int>.Default);

            Assert.AreEqual(heap.Type, HeapType.Minimum);
            Assert.AreEqual(heap.Count, 0);
            Assert.IsTrue(heap.IsEmpty);
        }
    }
}