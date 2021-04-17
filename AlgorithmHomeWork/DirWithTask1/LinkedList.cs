using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.DirWithTask1
{
    public class LinkedList : ILinkedList
    {
	    private Node _startNode;
	    private Node _endNode;
	    private int _count;

	    public int GetCount() => _count;

	    public void AddNode(int value)
	    {
		    var node = new Node();
		    node.Value = value;

		    if (_startNode == null)
			    _startNode = node;
		    else
		    {
			    _endNode.NextNode = node;
			    node.PrevNode = _endNode;
		    }

		    _endNode = node;
		    _count++;
	    }

	    public void AddNodeAfter(Node node, int value)
	    {
		    throw new NotImplementedException();
	    }

	    public void RemoveNode(int index)
	    {
		    throw new NotImplementedException();
	    }

	    public void RemoveNode(Node node)
	    {
		    throw new NotImplementedException();
	    }

	    public Node FindNode(int searchValue)
	    {
		    throw new NotImplementedException();
	    }

	    public Node GetByIndex(int index)
	    {
		    throw new NotImplementedException();
	    }
    }
}
