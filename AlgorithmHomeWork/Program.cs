using System;

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

			var node = binaryTree.BreadthFirstSearch(20);

			node = binaryTree.DeepFirstSearch(99);
		}
	}
}
