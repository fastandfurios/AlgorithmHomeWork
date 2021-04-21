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
					_startNode = node;
					_count--;
					break;
				}
				else if (index == _count - 1)
				{
					node = _endNode;
					node = node.PrevNode;
					node.NextNode = null;
					_count--;
					break;
				}
				else if (indexLinkedList == index)
				{
					node.PrevNode.NextNode = node.NextNode;
					node.NextNode.PrevNode = node.PrevNode;
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
		    var vertex = _startNode;

		    while (vertex != null)
		    {
			    if (vertex.Value == node.Value)
			    {
				    if (vertex.PrevNode == null)
				    {
					    vertex = vertex.NextNode;
					    vertex.PrevNode = null;
					    _startNode = vertex;
					    _count--;
						break;
					}
					else if (vertex.NextNode == null)
				    {
					    vertex = vertex.PrevNode;
						vertex.NextNode = null;
						_count--;
						break;
					}
				    else
				    {
						vertex.PrevNode.NextNode = vertex.NextNode;
						vertex.NextNode.PrevNode = vertex.PrevNode;
						_count--;
						break;
					}
			    }
			    else
				    vertex = vertex.NextNode;
		    }
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
