using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.BinaryTree
{
    public interface ITree
    {
	    TreeNode GetRoot();
	    void AddItem(int value);
	    void RemoveItem(int value);
	    TreeNode GetNodeByValue(int value);
	    void PrintTree();
	    TreeNode BreadthFirstSearch(int value);
	    TreeNode DepthFirstSearch(int value);
    }
}
