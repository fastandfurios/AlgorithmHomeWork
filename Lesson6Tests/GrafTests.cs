using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson6;

namespace Lesson6Tests
{
	[TestClass]
	public class GrafTests
	{
		private readonly Graf _graf = new Graf(8);

		[TestMethod]
		public void BreadthFirstSearch_0_7_returned_7()
		{
			_graf.AddEdge(0, 1);
			_graf.AddEdge(0, 2);
			_graf.AddEdge(0, 7);
			_graf.AddEdge(1, 4);
			_graf.AddEdge(2, 3);
			_graf.AddEdge(2, 4);
			_graf.AddEdge(3, 5);
			_graf.AddEdge(3, 6);
			_graf.AddEdge(6, 7);

			int startNode = 0;
			int value = 7;
			int expected = 7;

			int actual = _graf.BreadthFirstSearch(startNode, value);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BreadthFirstSearch_0_0_returned_0()
		{
			_graf.AddEdge(0, 1);
			_graf.AddEdge(0, 2);
			_graf.AddEdge(0, 7);
			_graf.AddEdge(1, 4);
			_graf.AddEdge(2, 3);
			_graf.AddEdge(2, 4);
			_graf.AddEdge(3, 5);
			_graf.AddEdge(3, 6);
			_graf.AddEdge(6, 7);

			int startNode = 0;
			int value = 0;
			int expected = 0;

			int actual = _graf.BreadthFirstSearch(startNode, value);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BreadthFirstSearch_0_12_returned_n1()
		{
			_graf.AddEdge(0, 1);
			_graf.AddEdge(0, 2);
			_graf.AddEdge(0, 7);
			_graf.AddEdge(1, 4);
			_graf.AddEdge(2, 3);
			_graf.AddEdge(2, 4);
			_graf.AddEdge(3, 5);
			_graf.AddEdge(3, 6);
			_graf.AddEdge(6, 7);

			int startNode = 0;
			int value = 12;
			int expected = -1;

			int actual = _graf.BreadthFirstSearch(startNode, value);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BreadthFirstSearch_2_7_returned_7()
		{
			_graf.AddEdge(0, 1);
			_graf.AddEdge(0, 2);
			_graf.AddEdge(0, 7);
			_graf.AddEdge(1, 4);
			_graf.AddEdge(2, 3);
			_graf.AddEdge(2, 4);
			_graf.AddEdge(3, 5);
			_graf.AddEdge(3, 6);
			_graf.AddEdge(6, 7);

			int startNode = 2;
			int value = 7;
			int expected = 7;

			int actual = _graf.BreadthFirstSearch(startNode, value);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BreadthFirstSearch_6_0_returned_0()
		{
			_graf.AddEdge(0, 1);
			_graf.AddEdge(0, 2);
			_graf.AddEdge(0, 7);
			_graf.AddEdge(1, 4);
			_graf.AddEdge(2, 3);
			_graf.AddEdge(2, 4);
			_graf.AddEdge(3, 5);
			_graf.AddEdge(3, 6);
			_graf.AddEdge(6, 7);

			int startNode = 6;
			int value = 0;
			int expected = 0;

			int actual = _graf.BreadthFirstSearch(startNode, value);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BreadthFirstSearch_18_0_returned_exception()
		{
			_graf.AddEdge(0, 1);
			_graf.AddEdge(0, 2);
			_graf.AddEdge(0, 7);
			_graf.AddEdge(1, 4);
			_graf.AddEdge(2, 3);
			_graf.AddEdge(2, 4);
			_graf.AddEdge(3, 5);
			_graf.AddEdge(3, 6);
			_graf.AddEdge(6, 7);

			int startNode = 18;
			int value = 0;

			Assert.ThrowsException<IndexOutOfRangeException>(() => _graf.BreadthFirstSearch(startNode, value));
		}

		[TestMethod]
		public void DepthFirstSearch_0_5_returned_5()
		{
			_graf.AddEdge(0, 1);
			_graf.AddEdge(0, 2);
			_graf.AddEdge(0, 7);
			_graf.AddEdge(1, 4);
			_graf.AddEdge(2, 3);
			_graf.AddEdge(2, 4);
			_graf.AddEdge(3, 5);
			_graf.AddEdge(3, 6);
			_graf.AddEdge(6, 7);

			int startNode = 0;
			int value = 5;
			int expected = 5;

			int actual = _graf.DepthFirstSearch(startNode, value);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void DepthFirstSearch_0_3_returned_3()
		{
			_graf.AddEdge(0, 1);
			_graf.AddEdge(0, 2);
			_graf.AddEdge(0, 7);
			_graf.AddEdge(1, 4);
			_graf.AddEdge(2, 3);
			_graf.AddEdge(2, 4);
			_graf.AddEdge(3, 5);
			_graf.AddEdge(3, 6);
			_graf.AddEdge(6, 7);

			int startNode = 0;
			int value = 3;
			int expected = 3;

			int actual = _graf.DepthFirstSearch(startNode, value);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void DepthFirstSearch_0_78_returned_5()
		{
			_graf.AddEdge(0, 1);
			_graf.AddEdge(0, 2);
			_graf.AddEdge(0, 7);
			_graf.AddEdge(1, 4);
			_graf.AddEdge(2, 3);
			_graf.AddEdge(2, 4);
			_graf.AddEdge(3, 5);
			_graf.AddEdge(3, 6);
			_graf.AddEdge(6, 7);

			int startNode = 0;
			int value = 78;
			int expected = 5;

			int actual = _graf.DepthFirstSearch(startNode, value);

			Assert.AreEqual(expected, actual);
		}
	}
}
