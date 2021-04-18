using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson1.DirWithTask3;

namespace Lesson1Tests
{
    [TestClass]
    public class Task2Tests
    {
	    private readonly NumbersFibonacci _task = new NumbersFibonacci();

	    [TestMethod]
	    public void CalculateNumberFibonacciRecursion_10_0_34_returned()
	    {
		    int n = 10;
		    int i = 0;
		    int expected = 55;

		    var actual = _task.CalculateNumberFibonacciRecursion(n, i);

			Assert.AreEqual(expected, actual);
	    }

	    [TestMethod]
	    public void CalculateNumberFibonacciRecursion_5_0_3_returned()
	    {
		    int n = 5;
		    int i = 0;
		    int expected = 5;

		    var actual = _task.CalculateNumberFibonacciRecursion(n, i);

		    Assert.AreEqual(expected, actual);
	    }

	    [TestMethod]
		public void CalculateNumberFibonacciRecursion_negativ5_0_3_returned()
	    {
		    int n = -5;
		    int i = 0;
		    int expected = 5;

		    var actual = _task.CalculateNumberFibonacciRecursion(n, i);

		    Assert.AreEqual(expected, actual);
	    }

		[TestMethod]
		public void CalculateNumberFibonacciRecursion_5_2_3_returned()
		{
			int n = 5;
			int i = 2;
			int expected = 5;

			var actual = _task.CalculateNumberFibonacciRecursion(n, i);

			Assert.AreEqual(expected, actual);
		}
	}
}
