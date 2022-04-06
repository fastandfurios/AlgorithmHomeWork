using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson8;

namespace Lesson8Tests
{
	[TestClass]
	public class BucketSortTests
	{
		private readonly BucketSortClass _bucketSort = new BucketSortClass();

		[TestMethod]
		public void Sort_array_notnull_returned_list_notnull()
		{
			int[] array = { 43, 17, 87, 92, 31, 6, 96, 13, 66, 62, 4 };
			int[] arrayExpected= { 4, 6, 13, 17, 31, 43, 62, 66, 87, 92, 96 };

			List<int> actuaList = _bucketSort.Sort(array);

			for (int i = 0; i < arrayExpected.Length; i++)
				Assert.AreEqual(arrayExpected[i], actuaList[i]);
		}

		[TestMethod]
		public void Sort_array_0_returned_list_0()
		{
			int[] array = { };
			int[] arrayExpected = { };

			List<int> actuaList = _bucketSort.Sort(array);

			for (int i = 0; i < arrayExpected.Length; i++)
				Assert.AreEqual(arrayExpected[i], actuaList[i]);
		}

		[TestMethod]
		public void Sort_array_null_result_exception()
		{
			int[] array = null;
			
			Assert.ThrowsException<NullReferenceException>((() => _bucketSort.Sort(array)));
		}
	}
}
