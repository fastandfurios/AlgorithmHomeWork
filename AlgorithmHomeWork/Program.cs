using System;
using Lesson4.TestsPerformanceHashSetAndArray;
using BenchmarkDotNet.Running;


namespace Lesson4
{
	class Program
	{
		static void Main(string[] args)
		{
			//BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

			var binaryTree = new BinaryTree.BinaryTree();
			binaryTree.AddItem(8);
			binaryTree.AddItem(5);
			binaryTree.AddItem(10);
			binaryTree.AddItem(3);
			binaryTree.AddItem(6);
			binaryTree.AddItem(9);
			binaryTree.AddItem(11);

			binaryTree.GetRoot();
		}
	}
}
