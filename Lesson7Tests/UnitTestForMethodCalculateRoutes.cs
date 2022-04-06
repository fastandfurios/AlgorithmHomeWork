using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson7;

namespace Lesson7Tests
{
	[TestClass]
	public class UnitTestForMethodCalculateRoutes
	{
		[TestMethod]
		public void CalculateRoutes_array_compare_array_success()
		{
			int[,] field = new int[5, 5];
			field[1, 1] = -1;
			field[3, 1] = -1;
			field[2, 3] = -1;

			int[,] arrayExpected = {{1, 1, 1, 1, 1}, {1, 0, 1, 2, 3}, {1, 1, 2, 0, 3}, {1, 0, 2, 2, 5}, {1, 1, 3, 5, 10}};
			Program.CalculateRoutes(field);

			for (int i = 0; i < field.GetLength(0); i++)
			{
				for (int j = 0; j < field.GetLength(1); j++)
					Assert.AreEqual(field[i,j], arrayExpected[i,j]);
			}
		}

		[TestMethod]
		public void CalculateRoutes_array_compare_array_different_values_error()
		{
			int[,] field = new int[5, 5];
			field[1, 1] = -1;
			field[3, 1] = -1;
			field[2, 3] = -1;

			int[,] arrayExpected = { { 1, 1, 1, 1, 1 }, { 1, 0, 1, 2, 3 }, { 1, 16, 2, 0, 3 }, { 1, 0, 2, 2, 5 }, { 1, 1, 3, 5, 10 } };
			Program.CalculateRoutes(field);

			for (int i = 0; i < field.GetLength(0); i++)
			{
				for (int j = 0; j < field.GetLength(1); j++)
					Assert.AreEqual(field[i, j], arrayExpected[i, j]);
			}
		}

		[TestMethod]
		public void CalculateRoutes_array_compare_array_different_length_error()
		{
			int[,] field = new int[5, 5];
			field[1, 1] = -1;
			field[3, 1] = -1;
			field[2, 3] = -1;

			int[,] arrayExpected = { { 1, 1, 1, 1, 1 }, { 1, 0, 1, 2, 3 }, { 1, 1, 2, 0, 3 }, { 1, 0, 2, 2, 5 } };
			int expected = arrayExpected.Length;
			int actual = field.Length;

			Assert.AreNotEqual(expected, actual);

		}

		[TestMethod]
		public void CalculateRoutes_array_null_result_exception()
		{
			int[,] field = null;

			Assert.ThrowsException<NullReferenceException>(() => Program.CalculateRoutes(field));
		}
	}
}
