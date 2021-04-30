using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson5.BinaryTree;

namespace Lesson5Tests
{
	[TestClass]
	public class BinaryTreeTests
	{
		private readonly BinaryTree _binaryTree = new BinaryTree();

		[TestMethod]
		public void BreadthFirstSearch_99_returned_99()
		{
			_binaryTree.AddItem(33);
			_binaryTree.AddItem(5);
			_binaryTree.AddItem(35);
			_binaryTree.AddItem(1);
			_binaryTree.AddItem(20);
			_binaryTree.AddItem(99);
			_binaryTree.AddItem(4);
			_binaryTree.AddItem(17);
			_binaryTree.AddItem(31);
			_binaryTree.AddItem(18);
			_binaryTree.AddItem(19);

			var value = 99;
			var expected = 99;

			var actual = _binaryTree.BreadthFirstSearch(value).Value;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BreadthFirstSearch_returned_null()
		{
			var value = 99;

			Assert.IsNull(_binaryTree.BreadthFirstSearch(value));
		}

		[TestMethod]
		public void BreadthFirstSearch_60_returned_null()
		{
			_binaryTree.AddItem(33);
			_binaryTree.AddItem(5);
			_binaryTree.AddItem(35);
			_binaryTree.AddItem(1);
			_binaryTree.AddItem(20);
			_binaryTree.AddItem(99);
			_binaryTree.AddItem(4);
			_binaryTree.AddItem(17);
			_binaryTree.AddItem(31);
			_binaryTree.AddItem(18);
			_binaryTree.AddItem(19);

			var value = 60;

			Assert.IsNull(_binaryTree.BreadthFirstSearch(value));
		}

		[TestMethod]
		public void BreadthFirstSearch_33_returned_notnull()
		{
			_binaryTree.AddItem(33);
			_binaryTree.AddItem(5);
			_binaryTree.AddItem(35);
			_binaryTree.AddItem(1);
			_binaryTree.AddItem(20);
			_binaryTree.AddItem(99);
			_binaryTree.AddItem(4);
			_binaryTree.AddItem(17);
			_binaryTree.AddItem(31);
			_binaryTree.AddItem(18);
			_binaryTree.AddItem(19);

			var value = 33;

			Assert.IsNotNull(_binaryTree.BreadthFirstSearch(value));
		}

		[TestMethod]
		public void DeepFirstSearch_returned_null()
		{
			var value = 19;

			Assert.IsNull(_binaryTree.BreadthFirstSearch(value));
		}

		[TestMethod]
		public void DeepFirstSearch_19_returned_19()
		{
			_binaryTree.AddItem(33);
			_binaryTree.AddItem(5);
			_binaryTree.AddItem(35);
			_binaryTree.AddItem(1);
			_binaryTree.AddItem(20);
			_binaryTree.AddItem(99);
			_binaryTree.AddItem(4);
			_binaryTree.AddItem(17);
			_binaryTree.AddItem(31);
			_binaryTree.AddItem(18);
			_binaryTree.AddItem(19);

			var value = 19;
			var expected = 19;

			var actual = _binaryTree.BreadthFirstSearch(value).Value;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void DeepFirstSearch_13_returned_null()
		{
			_binaryTree.AddItem(33);
			_binaryTree.AddItem(5);
			_binaryTree.AddItem(35);
			_binaryTree.AddItem(1);
			_binaryTree.AddItem(20);
			_binaryTree.AddItem(99);
			_binaryTree.AddItem(4);
			_binaryTree.AddItem(17);
			_binaryTree.AddItem(31);
			_binaryTree.AddItem(18);
			_binaryTree.AddItem(19);

			var value = 13;

			Assert.IsNull(_binaryTree.BreadthFirstSearch(value));
		}

		[TestMethod]
		public void DeepFirstSearch_19_returned_notnull()
		{
			_binaryTree.AddItem(33);
			_binaryTree.AddItem(5);
			_binaryTree.AddItem(35);
			_binaryTree.AddItem(1);
			_binaryTree.AddItem(20);
			_binaryTree.AddItem(99);
			_binaryTree.AddItem(4);
			_binaryTree.AddItem(17);
			_binaryTree.AddItem(31);
			_binaryTree.AddItem(18);
			_binaryTree.AddItem(19);

			var value = 19;

			Assert.IsNotNull(_binaryTree.BreadthFirstSearch(value));
		}
	}
}
