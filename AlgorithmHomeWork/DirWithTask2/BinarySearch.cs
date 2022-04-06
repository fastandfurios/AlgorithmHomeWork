using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.DirWithTask2
{
    public class BinarySearch
    {
	    public int BinarySearchMethod(int[] inputArray, int searchValue)
	    {
		    int min = 0; //O(1)
		    int max = inputArray.Length - 1;//O(1)
		    while (min <= max) // O(log2(n)) 
		    {
			    int mid = (min + max) / 2;
			    if (searchValue == inputArray[mid])
				    return mid;
				else if (searchValue < inputArray[mid])
				    max = mid - 1;
			    else
				    min = mid + 1;
		    }

		    return -1;
		} //O(log2(n) + 1 + 1) = O(log2(n))
	}
}
