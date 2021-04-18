using System;
using Lesson2.DirWithTask1;
using Lesson2.DirWithTask2;

namespace Lesson2
{
	class Program
	{
		static void Main(string[] args)
		{
			var linkedList = new LinkedList();
			linkedList.AddNode(5);
			linkedList.AddNode(6);
			linkedList.AddNode(10);

			linkedList.AddNodeAfter(new Node(), 6);

			var node = linkedList.FindNode(10);

			int result = linkedList.GetByIndex(1).Value;

			linkedList.RemoveNode(2);

			Console.WriteLine(linkedList.GetCount());
			
			//Задача 2
			var binarySearch = new BinarySearch();
			Console.WriteLine(binarySearch.BinarySearchMethod(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5));
		}
	}
}
