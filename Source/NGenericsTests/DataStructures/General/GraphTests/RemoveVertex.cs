﻿using System;
using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.GraphTest
{
    [TestFixture]
    public class RemoveVertex : GraphTests.GraphTest
    {
        [Test]
        public void Undirected()
        {
            var graph = new Graph<int>(false);
            var vertex1 = new Vertex<int>(1);
            var vertex2 = new Vertex<int>(2);
            var vertex3 = new Vertex<int>(3);
            var vertex4 = new Vertex<int>(4);

            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);
            graph.AddVertex(vertex3);

            graph.AddEdge(vertex1, vertex2);
            graph.AddEdge(vertex3, vertex2);
            graph.AddEdge(vertex1, vertex3);

            Assert.AreEqual(graph.Edges.Count, 3);
            Assert.AreEqual(graph.Vertices.Count, 3);

            Assert.IsTrue(graph.RemoveVertex(vertex1));

            Assert.AreEqual(graph.Edges.Count, 1);
            Assert.AreEqual(graph.Vertices.Count, 2);

            Assert.IsFalse(graph.RemoveVertex(vertex4));

            Assert.AreEqual(graph.Edges.Count, 1);
            Assert.AreEqual(graph.Vertices.Count, 2);

        }

        [Test]
        public void Directed()
        {
            var graph = new Graph<int>(true);
            var vertex1 = new Vertex<int>(1);
            var vertex2 = new Vertex<int>(2);
            var vertex3 = new Vertex<int>(3);
            var vertex4 = new Vertex<int>(4);

            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);
            graph.AddVertex(vertex3);

            graph.AddEdge(vertex1, vertex2);
            graph.AddEdge(vertex3, vertex2);
            graph.AddEdge(vertex1, vertex3);

            Assert.AreEqual(graph.Edges.Count, 3);
            Assert.AreEqual(graph.Vertices.Count, 3);

            Assert.IsTrue(graph.RemoveVertex(vertex1));

            Assert.AreEqual(graph.Edges.Count, 1);
            Assert.AreEqual(graph.Vertices.Count, 2);

            Assert.IsFalse(graph.RemoveVertex(vertex4));

            Assert.AreEqual(graph.Edges.Count, 1);
            Assert.AreEqual(graph.Vertices.Count, 2);
        }

        [Test]
        public void UndirectedValue()
        {
            var graph = new Graph<int>(false);
            var vertex1 = new Vertex<int>(1);
            var vertex2 = new Vertex<int>(2);
            var vertex3 = new Vertex<int>(3);

            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);
            graph.AddVertex(vertex3);

            graph.AddEdge(vertex1, vertex2);
            graph.AddEdge(vertex3, vertex2);
            graph.AddEdge(vertex1, vertex3);

            Assert.AreEqual(graph.Edges.Count, 3);
            Assert.AreEqual(graph.Vertices.Count, 3);

            Assert.IsTrue(graph.RemoveVertex(1));

            Assert.AreEqual(graph.Edges.Count, 1);
            Assert.AreEqual(graph.Vertices.Count, 2);

            Assert.IsFalse(graph.RemoveVertex(4));
            Assert.AreEqual(graph.Edges.Count, 1);
            Assert.AreEqual(graph.Vertices.Count, 2);
        }

        [Test]
        public void DirectedValue()
        {
            var graph = new Graph<int>(true);
            var vertex1 = new Vertex<int>(1);
            var vertex2 = new Vertex<int>(2);
            var vertex3 = new Vertex<int>(3);

            graph.AddVertex(vertex1);
            graph.AddVertex(vertex2);
            graph.AddVertex(vertex3);

            graph.AddEdge(vertex1, vertex2);
            graph.AddEdge(vertex3, vertex2);
            graph.AddEdge(vertex1, vertex3);

            Assert.AreEqual(graph.Edges.Count, 3);
            Assert.AreEqual(graph.Vertices.Count, 3);

            Assert.IsTrue(graph.RemoveVertex(1));

            Assert.AreEqual(graph.Edges.Count, 1);
            Assert.AreEqual(graph.Vertices.Count, 2);

            Assert.IsFalse(graph.RemoveVertex(4));
            Assert.AreEqual(graph.Edges.Count, 1);
            Assert.AreEqual(graph.Vertices.Count, 2);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionNullVertex()
        {
            var graph = new Graph<int>(true);
            graph.RemoveVertex(null);
        }
    }
}