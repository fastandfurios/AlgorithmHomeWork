using System;

namespace Lesson6
{
	class Program
	{
		static void Main(string[] args)
		{
			var graf = new Graf(8);
			graf.AddEdge(0, 1);
			graf.AddEdge(0, 2);
			graf.AddEdge(0, 7);
			graf.AddEdge(1, 4);
			graf.AddEdge(2, 3);
			graf.AddEdge(2, 4);
			graf.AddEdge(3, 5);
			graf.AddEdge(3, 6);
			graf.AddEdge(6, 7);

			Console.WriteLine("BFS: ");
			var result = graf.BreadthFirstSearch(0, 5);
			Console.WriteLine();
			Console.WriteLine("DFS:");
			result = graf.DepthFirstSearch(0, 5);
		}
	}
}
