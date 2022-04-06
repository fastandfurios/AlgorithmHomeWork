using System;
using Lesson1.DirWithTask1;
using Lesson1.DirWithTask3;

namespace Lesson1
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Задача 1
			var task1 = new Task1();
			Console.WriteLine(task1.CheckNumber(10));

			//Задача 3
			var task3 = new NumbersFibonacci();
			Console.WriteLine(task3.CalculateNumberFibonacciRecursion(5, 0));
			Console.WriteLine(task3.CalculateNumberFibonacciLoop(10));
		}
	}
}
