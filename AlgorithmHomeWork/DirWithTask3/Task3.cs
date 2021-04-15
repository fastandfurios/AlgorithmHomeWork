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

	    public void CalculateNumberFibonacciRecursion(int n, int i, int sum)
	    {
		    if (sum == 0 || sum == 1)
		    {
				_list.Add(sum);
				sum = ++i;
				CalculateNumberFibonacciRecursion(n, i, sum);
		    }

		    if (i < n)
		    {
			    sum = (sum - 2) + (sum - 1);
				_list.Add(sum);
				CalculateNumberFibonacciRecursion(n, ++i, sum);
		    }
	    }
    }
}
