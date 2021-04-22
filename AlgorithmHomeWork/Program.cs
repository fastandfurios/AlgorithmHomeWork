using System;
using Lesson3;

namespace AlgorithmHomeWork
{
	class Program
	{
		static void Main(string[] args)
		{
			var calculate = new CalculateDistance();

			var arrayForPointClassOne = new PointClassOne[]
			{
				new PointClassOne() { X = 42, Y = 34 },
				new PointClassOne() { X = 10, Y = 8 },
				new PointClassOne() { X = 17, Y = 15 },
				new PointClassOne() { X = 18, Y = 9 }
			};

			var arrayForPointClassTwo = new PointClassTwo[]
			{
				new PointClassTwo() { X = 22, Y = 14 },
				new PointClassTwo() { X = 6, Y = 4 },
				new PointClassTwo() { X = 7, Y = 3 },
				new PointClassTwo() { X = 8, Y = 2 }
			};

			var arrayForPointStructOne = new PointStructOne[]
			{
				new PointStructOne() { X = 42, Y = 34 },
				new PointStructOne() { X = 10, Y = 8 },
				new PointStructOne() { X = 17, Y = 15 },
				new PointStructOne() { X = 18, Y = 9 }
			};

			var arrayForPointStructTwo = new PointStructTwo[]
			{
				new PointStructTwo() { X = 22, Y = 14 },
				new PointStructTwo() { X = 6, Y = 4 },
				new PointStructTwo() { X = 7, Y = 3 },
				new PointStructTwo() { X = 8, Y = 2 }
			};

			var arrayForPointStructOneD = new PointStructOne[]
			{
				new PointStructOne() { pX = 42, pY = 34 },
				new PointStructOne() { pX = 10, pY = 8 },
				new PointStructOne() { pX = 17, pY = 15 },
				new PointStructOne() { pX = 18, pY = 9 }
			};

			var arrayForPointStructTwoD = new PointStructTwo[]
			{
				new PointStructTwo() { pX = 22, pY = 14 },
				new PointStructTwo() { pX = 6, pY = 4 },
				new PointStructTwo() { pX = 7, pY = 3 },
				new PointStructTwo() { pX = 8, pY = 2 }
			};

			for (int i = 0; i < arrayForPointClassOne.Length; i++)
				calculate.PointDistance(arrayForPointClassOne[i], arrayForPointClassTwo[i]);

			for (int i = 0; i < arrayForPointStructOne.Length; i++)
				calculate.PointDistance(arrayForPointStructOne[i], arrayForPointStructTwo[i]);

			for (int i = 0; i < arrayForPointStructOneD.Length; i++)
				calculate.PointDistanceD(arrayForPointStructOneD[i], arrayForPointStructTwoD[i]);

			for (int i = 0; i < arrayForPointStructOne.Length; i++)
				calculate.PointDistance(arrayForPointStructOne[i], arrayForPointStructTwo[i]);
		}
	}
}
