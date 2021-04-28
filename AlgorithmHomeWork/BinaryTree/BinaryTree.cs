﻿using System;
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
		    throw new NotImplementedException();
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