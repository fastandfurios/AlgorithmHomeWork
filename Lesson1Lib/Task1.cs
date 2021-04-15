using System;

namespace Lesson1Lib
{
	public class Task1
	{
		public string CheckNumber(int n)
		{
			int d = 0, i = 2;

			while (i < n)
			{
				if (n % i == 0)
					d++;
				else
					i++;
			}

			return d == 0 ? "Простое" : "Не простое";
		}
	}
}
