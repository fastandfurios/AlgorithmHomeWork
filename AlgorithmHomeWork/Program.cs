using System;

namespace Lesson7
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[,] field = new int[5, 5];
			field[1, 1] = -1;
			field[3, 1] = -1;
			field[2, 3] = -1;

			CalculateRoutes(field);

			Print(field.GetLength(0), field.GetLength(1), field);
		}

		public static void CalculateRoutes(int[,] field)
		{
			for (int i = 0; i < field.GetLength(0); i++)
			{
				for (int j = 0; j < field.GetLength(1); j++)
				{
					if (i == 0 || j == 0)
						field[i, j] = 1;
					else if (field[i, j] == -1)
						field[i, j] = 0;
					else
						field[i, j] = field[i, j - 1] + field[i - 1, j];
				}
			}
		}

		static void Print(int row, int column, int[,] field)
		{
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
					Console.Write(field[i, j]);
				
				Console.Write("\r\n");
			}
		}
	}
}
