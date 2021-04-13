using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Task1
    {
	    private int _number;

	    public void Run() => RunAlgorithm();

	    private void RunAlgorithm()
	    {
		    Console.WriteLine("Введите число");
		    _number = Convert.ToInt32(Console.ReadLine());
		    int d = 0, i = 2;

		    while (i < _number)
		    {
			    if(_number % i == 0)
				    d++;
			    else
				    i++;
		    }

		    Console.WriteLine(d == 0 ? "Простое" : "Не простое");
	    }
    }
}
