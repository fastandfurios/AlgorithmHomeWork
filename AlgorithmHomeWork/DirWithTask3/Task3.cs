using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DirWithTask3
{
    public class Task3
    {
	    private readonly List<int> _list = new List<int>();

	    public int CalculateNumberFibonacciRecursion(int n, int i)
	    {
		    if (i <= n)
		    {
			    if (i == 0 || i == 1)
				    _list.Add(i);
			    else
				    _list.Add(_list[i - 2] + _list[i - 1]);
				
				CalculateNumberFibonacciRecursion(n, ++i);
		    }

		    return _list[_list.Count - 1];
	    }

	    public int CalculateNumberFibonacciLoop(int n)
	    {
		    _list.RemoveRange(0, _list.Count);

		    for (int i = 0; i <= n; i++)
		    {
				if (i == 0 || i == 1)
					_list.Add(i);
				else
					_list.Add(_list[i - 2] + _list[i - 1]);
			}

			return _list[_list.Count - 1];
	    }
    }
}
