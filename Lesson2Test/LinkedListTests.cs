using System;
using Lesson2.DirWithTask1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson2Tests
{
    [TestClass]
    public class LinkedListTests
    { 
	    private readonly LinkedList _linkedList = new LinkedList();

	    [TestMethod]
	    public void GetCount_returned_3()
	    {
		    _linkedList.AddNode(5);
			_linkedList.AddNode(6);
			_linkedList.AddNode(7);

		    int expected = 3;

		    int actual = _linkedList.GetCount();

			Assert.AreEqual(expected, actual);
	    }

	    [TestMethod]
	    public void GetCount_returned_0()
	    {
		    int expected = 0;

		    int actual = _linkedList.GetCount();

		    Assert.AreEqual(expected, actual);
	    }

	    [TestMethod]
	    public void GetByIndex_2_returned_7()
	    {
			_linkedList.AddNode(5);
			_linkedList.AddNode(6);
			_linkedList.AddNode(7);

			int index = 2;
			int expected = 7;

			int actual = _linkedList.GetByIndex(index).Value;

			Assert.AreEqual(expected, actual);
	    }

	    [TestMethod]
	    public void GetByIndex_3_Exception()
	    {
		    _linkedList.AddNode(5);
		    _linkedList.AddNode(6);
		    _linkedList.AddNode(7);

		    int index = 3;

		    Assert.ThrowsException<NullReferenceException>(() => _linkedList.GetByIndex(index).Value);
	    }

	    [TestMethod]
	    public void FindNode_7_returned_7()
	    {
		    _linkedList.AddNode(5);
		    _linkedList.AddNode(6);
		    _linkedList.AddNode(7);

		    int searchValue = 7;
		    int expected = 7;

		    int actual = _linkedList.FindNode(searchValue).Value;

		    Assert.AreEqual(expected, actual);
	    }

	    [TestMethod]
	    public void FindNode_15_Exception()
	    {
		    _linkedList.AddNode(5);
		    _linkedList.AddNode(6);
		    _linkedList.AddNode(7);

		    int searchValue = 15;
		    int expected = 15;

		    int actual = _linkedList.FindNode(searchValue).Value;

		    Assert.AreEqual(expected, actual);
	    }


		[TestMethod]
	    public void AddNode_value_85_36_77_17_1()
	    {
		    _linkedList.AddNode(85);
		    _linkedList.AddNode(36);
		    _linkedList.AddNode(77);
		    _linkedList.AddNode(17);
		    _linkedList.AddNode(1);

		    var arrayExpected = new int[] {85, 36, 77, 17, 1};

		    for (int i = 0; i < _linkedList.GetCount() - 1; i++)
			    Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
	    }

	    [TestMethod]
	    public void AddNode__value_85_36_77_17_1_error()
	    {
		    _linkedList.AddNode(85);
		    _linkedList.AddNode(36);
		    _linkedList.AddNode(77);
		    _linkedList.AddNode(17);
		    _linkedList.AddNode(1);

		    var arrayExpected = new int[] { 85, 36, 68, 77, 17, 1 };

		    for (int i = 0; i < _linkedList.GetCount() - 1; i++)
			    Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
	    }

		[TestMethod]
	    public void AddNodeAfter_node_value_105_value_6()
	    {
		    _linkedList.AddNode(5);
		    _linkedList.AddNode(6);
		    _linkedList.AddNode(7);
			_linkedList.AddNodeAfter(new Node(){Value = 105}, 6);

			var arrayExpected = new int[] { 5, 6, 105, 7 };

			for (int i = 0; i < _linkedList.GetCount() - 1; i++)
				Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
		}

	    [TestMethod]
	    public void AddNodeAfter_linkedList_node_value_105_value_10()
	    {
		    _linkedList.AddNode(5);
		    _linkedList.AddNode(6);
		    _linkedList.AddNode(7);
		    _linkedList.AddNodeAfter(new Node() { Value = 105 }, 10);

		    var arrayExpected = new int[] { 5, 6, 105, 7 };

		    for (int i = 0; i < _linkedList.GetCount() - 1; i++)
			    Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
	    }

		[TestMethod]
	    public void AddNodeAfter_node_value_6()
	    {
		    _linkedList.AddNode(5);
		    _linkedList.AddNode(6);
		    _linkedList.AddNode(7);
		    _linkedList.AddNodeAfter(new Node(), 6);

		    var arrayExpected = new int[] { 5, 6, 105, 7 };

		    for (int i = 0; i < _linkedList.GetCount() - 1; i++)
			    Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
	    }

	    [TestMethod]
	    public void AddNodeAfter_null_value_6()
	    {
		    _linkedList.AddNode(5);
		    _linkedList.AddNode(6);
		    _linkedList.AddNode(7);
		    _linkedList.AddNodeAfter(null, 6);

		    var arrayExpected = new int[] { 5, 6, 105, 7 };

		    for (int i = 0; i < _linkedList.GetCount() - 1; i++)
			    Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
	    }

	    [TestMethod]
	    public void RemoveNode_index_3()
	    {
		    _linkedList.AddNode(85);
		    _linkedList.AddNode(36);
		    _linkedList.AddNode(77);
		    _linkedList.AddNode(17);
		    _linkedList.AddNode(1);

			_linkedList.RemoveNode(3);

		    var arrayExpected = new int[] { 85, 36, 77, 1 };

		    for (int i = 0; i < _linkedList.GetCount() - 1; i++)
			    Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
	    }

	    [TestMethod]
	    public void RemoveNode_index_10()
	    {
		    _linkedList.AddNode(85);
		    _linkedList.AddNode(36);
		    _linkedList.AddNode(77);
		    _linkedList.AddNode(17);
		    _linkedList.AddNode(1);

		    _linkedList.RemoveNode(10);

		    var arrayExpected = new int[] { 85, 36, 77, 1 };

		    for (int i = 0; i < _linkedList.GetCount() - 1; i++)
			    Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
	    }

	    [TestMethod]
	    public void RemoveNode_node_value_77()
	    {
		    _linkedList.AddNode(85);
		    _linkedList.AddNode(36);
		    _linkedList.AddNode(77);
		    _linkedList.AddNode(17);
		    _linkedList.AddNode(1);

		    _linkedList.RemoveNode(new Node(){ Value = 77 });

		    var arrayExpected = new int[] { 85, 36, 17, 1 };

		    for (int i = 0; i < _linkedList.GetCount() - 1; i++)
			    Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
	    }

	    [TestMethod]
	    public void RemoveNode_node()
	    {
		    _linkedList.AddNode(85);
		    _linkedList.AddNode(36);
		    _linkedList.AddNode(77);
		    _linkedList.AddNode(17);
		    _linkedList.AddNode(1);

		    _linkedList.RemoveNode(new Node());

		    var arrayExpected = new int[] { 85, 36, 17, 1 };

		    for (int i = 0; i < _linkedList.GetCount() - 1; i++)
			    Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
	    }

	    [TestMethod]
	    public void RemoveNode_node_value_53()
	    {
		    _linkedList.AddNode(85);
		    _linkedList.AddNode(36);
		    _linkedList.AddNode(77);
		    _linkedList.AddNode(17);
		    _linkedList.AddNode(1);

		    _linkedList.RemoveNode(new Node() { Value = 53 });

		    var arrayExpected = new int[] { 85, 36, 17, 1 };

		    for (int i = 0; i < _linkedList.GetCount() - 1; i++)
			    Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
	    }

	    [TestMethod]
	    public void RemoveNode_null()
	    {
		    _linkedList.AddNode(85);
		    _linkedList.AddNode(36);
		    _linkedList.AddNode(77);
		    _linkedList.AddNode(17);
		    _linkedList.AddNode(1);

		    _linkedList.RemoveNode(null);

		    var arrayExpected = new int[] { 85, 36, 17, 1 };

		    for (int i = 0; i < _linkedList.GetCount() - 1; i++)
			    Assert.AreEqual(arrayExpected[i], _linkedList.GetByIndex(i).Value);
	    }
	}
}
