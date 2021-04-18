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
		    node.Value = value;



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
				}
				else if (index == _count - 1)
				{
					node = _endNode;
					node = node.PrevNode;
					node.NextNode = null;
				}
				else if (indexLinkedList == index)
				{
					node = node.NextNode;
					node = node.PrevNode;
					node.Value = node.NextNode.Value;
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
