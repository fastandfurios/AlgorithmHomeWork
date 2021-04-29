using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson4.BinaryTree;

namespace Lesson4Tests
{
	[TestClass]
	public class BinaryTreeTests
	{
		private readonly BinaryTree _binaryTree = new BinaryTree();
		private readonly TreeNode _treeNode = new TreeNode();

		[TestMethod]
		public void GetRoot_returned_null()
		{
			var actual = _binaryTree.GetRoot();

			Assert.IsNull(actual);
		}

		[TestMethod]
		public void GetRoot_returned_notnull()
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

			var actual = _binaryTree.GetRoot();

			Assert.IsNotNull(actual);
		}

		[TestMethod]
		public void GetRoot_returned_33()
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

			var expected = 33;

			var actual = _binaryTree.GetRoot().Value;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetRoot_returned_error()
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

			var expected = 99;

			var actual = _binaryTree.GetRoot().Value;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetNodeByValue_99_returned_99()
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

			var expected = 99;

			var actual = _binaryTree.GetNodeByValue(expected).Value;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetNodeByValue_99_returned_notnull()
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

			var actual = _binaryTree.GetNodeByValue(value);

			Assert.IsNotNull(actual);
		}

		[TestMethod]
		public void GetNodeByValue_100_returned_error()
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

			var value = 100;

			var actual = _binaryTree.GetNodeByValue(value);

			Assert.IsNull(actual);
		}

		[TestMethod]
		public void AddItem_33_5_35_1_20_99_4_17_31_18_19_returned_notnull()
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

			Assert.IsNotNull(_binaryTree);
		}

		[TestMethod]
		public void AddItem_33_5_35_1_20_99_4_17_31_18_19_returned_33_5_35_1_20_99_4_17_31_18_19()
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

			var arrayExpected = new int[] { 33, 5, 35, 1, 20, 99, 4, 17, 31, 18, 19 };

			for (int i = 0; i < arrayExpected.Length; i++)
				Assert.AreEqual(arrayExpected[i], _binaryTree.GetNodeByValue(arrayExpected[i]).Value);
		}

		[TestMethod]
		public void AddItem_33_5_35_1_20_99_4_17_31_18_19_returned_error()
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

			var arrayExpected = new int[] { 33, 5, 35, 1, 20, 99, 4, 17, 31, 18, 19, 23 };

			for (int i = 0; i < arrayExpected.Length; i++)
				Assert.AreEqual(arrayExpected[i], _binaryTree.GetNodeByValue(arrayExpected[i]).Value);
		}

		[TestMethod]
		public void AddItem_33_5_35_1_20_4_17_31_18_19_returned_error()
		{
			_binaryTree.AddItem(33);
			_binaryTree.AddItem(5);
			_binaryTree.AddItem(35);
			_binaryTree.AddItem(1);
			_binaryTree.AddItem(20);
			_binaryTree.AddItem(4);
			_binaryTree.AddItem(17);
			_binaryTree.AddItem(31);
			_binaryTree.AddItem(18);
			_binaryTree.AddItem(19);

			var arrayExpected = new int[] { 33, 5, 35, 1, 20, 99, 4, 17, 31, 18 };

			for (int i = 0; i < arrayExpected.Length; i++)
				Assert.AreEqual(arrayExpected[i], _binaryTree.GetNodeByValue(arrayExpected[i]).Value);
		}

		[TestMethod]
		public void RemoveItem_20_returned_success()
		{
			_binaryTree.AddItem(33);
			_binaryTree.AddItem(5);
			_binaryTree.AddItem(35);
			_binaryTree.AddItem(1);
			_binaryTree.AddItem(20);
			_binaryTree.AddItem(99);
			_binaryTree.AddItem(4);
			_binaryTree.AddItem(17);
			_binaryTree.AddItem(18);
			_binaryTree.AddItem(19);

			var value = 20;

			_binaryTree.RemoveItem(value);

			var arrayExpected = new int[] { 33, 5, 35, 1, 17, 99, 4, 18, 19 };

			for (int i = 0; i < arrayExpected.Length; i++)
				Assert.AreEqual(arrayExpected[i], _binaryTree.GetNodeByValue(arrayExpected[i]).Value);
		}
	}
}
