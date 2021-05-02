using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.BinaryTree
{
    public class BinaryTree : ITree
    {
	    private TreeNode _root, _current, _temp;
	    private readonly Queue<TreeNode> _queue = new Queue<TreeNode>();
	    private readonly Stack<TreeNode> _stack = new Stack<TreeNode>();

	    public TreeNode GetRoot()
	    {
		    if (_root != null)
			    return _root;

		    return null;
	    }

	    public void AddItem(int value)
	    {
		    if (_root == null)
		    {
			    _root = new TreeNode { Value = value };
			    _current = _root;
		    }
		    else
		    {
			    if (_current.Value > value)
			    {
				    if (_current.LeftChild == null)
				    {
					    _current.LeftChild = new TreeNode
					    {
						    Value = value,
						    Parent = _current
					    };
				    }
				    else
				    {
					    _current = _current.LeftChild;
					    AddItem(value);
					    _current = _root;
				    }
			    }

			    if (_current.Value < value)
			    {
				    if (_current.RightChild == null)
				    {
					    _current.RightChild = new TreeNode
					    {
						    Value = value,
						    Parent = _current
					    };
				    }
				    else
				    {
					    _current = _current.RightChild;
					    AddItem(value);
					    _current = _root;
				    }
			    }
		    }
	    }

	    public void RemoveItem(int value)
	    {
		    if (this.GetNodeByValue(value) != null)
		    {
			    if (_root.Value == value)
				    _root = null;

			    if (_current != null)
			    {
				    if (_current.Value > value)
				    {
					    if (_current.Value == value)
						    if (_current.RightChild == null && _current.LeftChild == null)
							    _current.Parent.LeftChild = null;
						    else
							    Remove();
					    else
					    {
						    _current = _current.LeftChild;
						    RemoveItem(value);
						    _current = _root;
					    }
				    }
				    else
				    {
					    if (_current.Value == value)
						    if (_current.RightChild == null && _current.LeftChild == null)
							    _current.Parent.RightChild = null;
						    else
							    Remove();
					    else
					    {
						    _current = _current.RightChild;
						    RemoveItem(value);
						    _current = _root;
					    }
				    }
			    }
			}
			else
				throw new NullReferenceException();
	    }

	    private void Remove()
	    {
		    if (_current.LeftChild != null && _current.RightChild == null)
		    {
			    _current.Parent.RightChild = _current.LeftChild;
			    _current.LeftChild.Parent = _current.Parent;
		    }
		    else if (_current.LeftChild == null && _current.RightChild != null)
		    {
			    _current.Parent.RightChild = _current.RightChild;
			    _current.RightChild.Parent = _current.Parent;
		    }
		    else if (_current.LeftChild != null && _current.RightChild != null)
		    {
			    if (_current.RightChild.RightChild != null)
			    {
				    _current.RightChild.LeftChild = _current.LeftChild;
				    _current.LeftChild.Parent = _current.RightChild;
				    _current.Parent.LeftChild = _current.RightChild;
				    _current.RightChild.Parent = _current.Parent;
			    }
			    else
			    {
				    _current.RightChild.Parent = _current.Parent;
				    _current.RightChild.LeftChild = _current.LeftChild;
				    _current.LeftChild.Parent = _current.RightChild;
				    _current.Parent.RightChild = _current.RightChild;
			    }
		    }
		}

	    public TreeNode GetNodeByValue(int value)
	    {
		    if (_root.Value == value)
			    return _root;

		    if (_current != null)
		    {
			    if (_current.Value > value)
			    {
				    if (_current.Value == value)
				    {
					    _temp = _current;
					    return _temp;
					}
				    else
				    {
						_current = _current.LeftChild;
						GetNodeByValue(value);
						_current = _root;
					}
			    }
			    else
			    {
				    if (_current.Value == value)
				    {
					    _temp = _current;
					    return _temp;
					}
				    else
				    {
						_current = _current.RightChild;
						GetNodeByValue(value);
						_current = _root;
					}
			    }
		    }
			
		    return _temp;
	    }

	    public void PrintTree() => _root.PrintPretty("", true);

	    public TreeNode BreadthFirstSearch(int value)
	    {
			if(_root != null)
				_queue.Enqueue(_root);
		    
		    while (_queue.Count != 0)
		    {
			    var currentNode = _queue.Dequeue();
			    Console.WriteLine(currentNode.Value);
			    if (value == currentNode.Value)
				    return currentNode;

			    if (currentNode.LeftChild != null)
				    _queue.Enqueue(currentNode.LeftChild);

			    if (currentNode.RightChild != null)
				    _queue.Enqueue(currentNode.RightChild);
		    }

		    return null;
	    }

	    public TreeNode DepthFirstSearch(int value)
	    {
			if(_root != null)
				_stack.Push(_root);

		    while (_stack.Count != 0)
		    {
			    var currentNode = _stack.Pop();
			    Console.WriteLine(currentNode.Value);
			    if (value == currentNode.Value)
				    return currentNode;

			    if (currentNode.RightChild != null)
				    _stack.Push(currentNode.RightChild);

				if (currentNode.LeftChild != null)
				    _stack.Push(currentNode.LeftChild);
		    }

		    return null;
	    }
    }
}
