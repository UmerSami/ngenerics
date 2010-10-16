﻿using System;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.ObjectMatrixTests
{
    [TestFixture]
    public class GetRow:ObjectMatrixTest
    {
        [Test]
        public void Simple()
        {
            var matrix = GetTestMatrix();

            var columnCount = matrix.Columns;
            var rowCount = matrix.Rows;

            var row = matrix.GetRow(0);

            Assert.AreEqual(matrix.Columns, columnCount);
            Assert.AreEqual(matrix.Rows, rowCount);

            Assert.AreEqual(row.Length, matrix.Columns);

            for (var i = 0; i < row.Length; i++)
            {
                Assert.AreEqual(row[i], i);
            }

            row = matrix.GetRow(1);

            Assert.AreEqual(row.Length, matrix.Columns);

            for (var i = 0; i < row.Length; i++)
            {
                Assert.AreEqual(row[i], i + 1);
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionNegativeRowIndex()
        {
            var matrix = GetTestMatrix();
            matrix.GetRow(-1);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionRowIndexTooLarge1()
        {
            var matrix = GetTestMatrix();
            matrix.GetRow(matrix.Rows);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionRowIndexTooLarge2()
        {
            var matrix = GetTestMatrix();
            matrix.GetRow(matrix.Rows + 1);
        }

    }
}