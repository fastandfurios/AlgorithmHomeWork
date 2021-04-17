using System;
using Lesson2.DirWithTask1;
using Lesson2.DirWithTask2;

namespace Lesson2
{
	class Program
	{
		static void Main(string[] args)
		{
			
			
			//Задача 2
			var binarySearch = new BinarySearch();
			Console.WriteLine(binarySearch.BinarySearchMethod(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5));
		}
	}
}
