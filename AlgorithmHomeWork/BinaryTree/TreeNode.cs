using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.BinaryTree
{
    public class TreeNode
    {
		#region Fields and prop
		private int _value;
		public int Value
		{
			get => _value;
			set => _value = value;
		}

		private TreeNode _leftChild;
		public TreeNode LeftChild
		{
			get => _leftChild;
			set => _leftChild = value;
		}

		private TreeNode _rightChild;
		public TreeNode RightChild
		{
			get => _rightChild;
			set => _rightChild = value;
		}

		public TreeNode Parent { get; set; }
		#endregion

		public override bool Equals(object obj)
	    {
		    var node = obj as TreeNode;

		    if (node == null)
			    return false;

		    return node.Value == _value;
	    }

	    public void PrintPretty(string indent, bool last)
	    {
			Console.Write(indent);
			if (last)
			{
				Console.Write("└─");
				indent += "  ";
			}
			else
			{
				Console.Write("├─");
				indent += "| ";
			}
			Console.WriteLine(_value);

			var children = new List<TreeNode>();
			if(_leftChild != null)
				children.Add(_leftChild);
			if(_rightChild != null)
				children.Add(_rightChild);

			for (int i = 0; i < children.Count; i++)
				children[i].PrintPretty(indent, i == children.Count - 1);
	    }
    }
}
