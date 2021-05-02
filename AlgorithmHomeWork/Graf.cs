using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Graf
    {
	    private int _vertices, _temp;
	    private List<int>[] _adjency;
	    private Queue<int> _queue = new Queue<int>();
	    private bool[] _visited;

	    public Graf(int vertices)
	    {
		    _vertices = vertices;
		    _adjency = new List<int>[vertices];

		    for (int i = 0; i < vertices; i++)
			    _adjency[i] = new List<int>();

		    _visited = new bool[_vertices];
	    }

	    public void AddEdge(int vertice, int relatedVertice)
		    => _adjency[vertice].Add(relatedVertice);

	    public int BreadthFirstSearch(int startVertice, int value)
	    {
		    bool[] visited = new bool[_vertices];

		    if (startVertice <= visited.Length)
		    {
			    visited[startVertice] = true;
			    _queue.Enqueue(startVertice);

			    while (_queue.Count != 0)
			    {
				    startVertice = _queue.Dequeue();
				    Console.Write($"{startVertice} ");

				    foreach (var next in _adjency[startVertice])
				    {
					    if (next == value)
						    return next;

					    if (!visited[next])
					    {
						    visited[next] = true;
						    _queue.Enqueue(next);
					    }
				    }
			    }
		    }
		    else
			    throw new IndexOutOfRangeException();

		    return -1;
	    }

	    public int DepthFirstSearch(int startVertice, int value)
	    {
		    _visited[startVertice] = true;
		    Console.Write($"{startVertice} ");

		    if (_adjency[startVertice] != null)
		    {
			    foreach (var item in _adjency[startVertice])
			    {
				    if (item == value)
				    {
					    _temp = item;
					    return _temp;
				    }
					    

				    if(!_visited[item] == true)
						DepthFirstSearch(item, value);
			    }
		    }

		    return _temp;
	    }
    }
}
