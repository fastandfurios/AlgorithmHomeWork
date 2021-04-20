using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson2.DirWithTask2;

namespace Lesson2Tests
{
	[TestClass]
	public class BinarySearchTests
	{
		private readonly BinarySearch _binarySearch = new BinarySearch();

		[TestMethod]
		public void BinarySearchMethod_array10_5_returned_5()
		{
			int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
			int searchValue = 5;
			const int expected = 5;

			int actual = _binarySearch.BinarySearchMethod(array, searchValue);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BinarySearchMethod_array10_6_returned_6()
		{
			int[] array = { 0, 81, 5, 3, 4, 5, 6, 7, 18, 9 };
			int searchValue = 6;
			const int expected = 6;

			int actual = _binarySearch.BinarySearchMethod(array, searchValue);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BinarySearchMethod_array5_3_returned_3()
		{
			int[] array = { 1, 81, 5, 3, 4 };
			int searchValue = 3;
			const int expected = 3;

			int actual = _binarySearch.BinarySearchMethod(array, searchValue);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BinarySearchMethod_array0_0_returned_0()
		{
			int[] array = { };
			int searchValue = 0;
			const int expected = 0;

			int actual = _binarySearch.BinarySearchMethod(array, searchValue);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BinarySearchMethod_array10_negativ5_returned_negativ5()
		{
			int[] array = { 0, -1, -2, -3, -4, -5, -6, -7, -8, -9 };
			int searchValue = -5;
			const int expected = -5;

			int actual = _binarySearch.BinarySearchMethod(array, searchValue);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BinarySearchMethod_array10_4_returned_4()
		{
			int[] array = { 0, -1, 2, -3, 4, -5, 6, 7, -8, 9 };
			int searchValue = 4;
			const int expected = 4;

			int actual = _binarySearch.BinarySearchMethod(array, searchValue);

			Assert.AreEqual(expected, actual);
		}
	}
}
