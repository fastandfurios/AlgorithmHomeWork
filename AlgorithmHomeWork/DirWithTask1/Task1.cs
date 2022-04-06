using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DirWithTask1
{
    public class Task1
    {
	    public string CheckNumber(int n)
	    {
		    int d = 0, i = 2;

		    while (i < n)
		    {
			    if(n % i == 0)
				    d++;
			    
			    i++;
		    }

		    return d == 0 ? "Простое" : "Не простое";
	    }
    }
}
