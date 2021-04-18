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
		    var vertex = _startNode;

		    while (vertex != null)
		    {
			    if (vertex.Value == value)
			    {
				    node.NextNode = vertex.NextNode;
				    node.PrevNode = vertex;
				    vertex.NextNode = node;
				    node.Value = 8;
					break;
			    }
			    else
				    vertex = vertex.NextNode;
		    }

		    _count++;
	    }

	    public void RemoveNode(int index)
	    {
			int indexLinkedList = 0;
			var node = _startNode;

			while (node != null)
			{
				if (index == 0)
				{
					node = node.NextNode;
					node.PrevNode = null;
					_count--;
				}
				else if (index == _count - 1)
				{
					node = _endNode;
					node = node.PrevNode;
					node.NextNode = null;
					_count--;
				}
				else if (indexLinkedList == index)
				{
					node = node.NextNode;
					node = node.PrevNode;
					node.Value = node.NextNode.Value;
					_count--;
					break;
				}
				else
				{
					node = node.NextNode;
					indexLinkedList++;
				}
			}
		}

	    public void RemoveNode(Node node)
	    {
		    throw new NotImplementedException();
	    }

	    public Node FindNode(int searchValue)
	    {
		    var node = _startNode;

		    while (node != null)
		    {
			    if (node.Value == searchValue)
				    break;
			    else
				    node = node.NextNode;
		    }

		    return node;
	    }

	    public Node GetByIndex(int index)
	    {
		    int indexLinkedList = 0;
		    var node = _startNode;

			while (node != null)
			{
				if (indexLinkedList == index)
					break;
				else
				{
					node = node.NextNode;
					indexLinkedList++;
				}
			}

			return node;
		}
    }
}
