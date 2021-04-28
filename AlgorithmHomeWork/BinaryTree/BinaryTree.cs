using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.BinaryTree
{
    public class BinaryTree : ITree
    {
	    private TreeNode _root, _current;

	    public TreeNode GetRoot()
	    {
		    if (_root.Parent == null && _root != null)
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
		    if (_root.Value == value)
			    _root = null;

		    if (_current != null)
		    {
			    if (_current.Value > value)
			    {
				    if (_current.Value == value)
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
					    else if (_current.LeftChild == null && _current.RightChild == null)
						    _current.Parent.LeftChild = null;
					}
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
					    else
						    _current.Parent.RightChild = null;
					}
				    else
				    {
					    _current = _current.RightChild;
					    RemoveItem(value);
					    _current = _root;
				    }
				}
		    }
	    }

	    public TreeNode GetNodeByValue(int value)
	    {
		    throw new NotImplementedException();
	    }

	    public void PrintTree()
	    {
		    throw new NotImplementedException();
	    }
    }
}
