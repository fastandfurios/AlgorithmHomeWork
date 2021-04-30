using System;
using BenchmarkDotNet.Running;


namespace Lesson5
{
	class Program
	{
		static void Main(string[] args)
		{

			var binaryTree = new BinaryTree.BinaryTree();
			binaryTree.AddItem(33);
			binaryTree.AddItem(5);
			binaryTree.AddItem(35);
			binaryTree.AddItem(1);
			binaryTree.AddItem(20);
			binaryTree.AddItem(99);
			binaryTree.AddItem(4);
			binaryTree.AddItem(17);
			binaryTree.AddItem(31);
			binaryTree.AddItem(18);
			binaryTree.AddItem(19);

			binaryTree.PrintTree();

			binaryTree.GetRoot();

			binaryTree.RemoveItem(31);

			binaryTree.RemoveItem(20);

			binaryTree.RemoveItem(17);

			binaryTree.AddItem(34);

			binaryTree.RemoveItem(35);

			binaryTree.RemoveItem(5);

			var node = binaryTree.GetNodeByValue(4);

			node = binaryTree.GetNodeByValue(18);

			binaryTree.PrintTree();
		}
	}
}
