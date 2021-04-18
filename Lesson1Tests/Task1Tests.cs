using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson1.DirWithTask1;

namespace Lesson1Tests
{
	[TestClass]
	public class Task1Tests
	{
		private readonly Task1 _task = new Task1();


		[TestMethod]
		public void CheckNumber_10_not_simple_returned()
		{
			int number = 10;
			string expected = "Не простое";

			string actual = _task.CheckNumber(number);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CheckNumber_5_simple_returned()
		{
			int number = 5;
			string expected = "Простое";

			string actual = _task.CheckNumber(number);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CheckNumber_0()
		{
			int number = 0;
			string expected = string.Empty;

			string actual = _task.CheckNumber(number);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CheckNumber_negativ5()
		{
			int number = -5;
			string expected = string.Empty;

			string actual = _task.CheckNumber(number);

			Assert.AreEqual(expected, actual);
		}
	}
}
