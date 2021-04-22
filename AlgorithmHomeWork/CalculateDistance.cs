using System;
using BenchmarkDotNet.Attributes;

namespace Lesson3
{
	public class CalculateDistance
	{
		private PointClassOne[] _arrayForPointClassOne =
		{
			new PointClassOne() { X = 42, Y = 34 },
			new PointClassOne() { X = 10, Y = 8 },
			new PointClassOne() { X = 17, Y = 15 },
			new PointClassOne() { X = 18, Y = 9 }
		};

		private PointClassTwo[] _arrayForPointClassTwo =
		{
			new PointClassTwo() { X = 22, Y = 14 },
			new PointClassTwo() { X = 6, Y = 4 },
			new PointClassTwo() { X = 7, Y = 3 },
			new PointClassTwo() { X = 8, Y = 2 }
		};

		private PointStructOne[] _arrayForPointStructOne =
		{
			new PointStructOne() { X = 42, Y = 34 },
			new PointStructOne() { X = 10, Y = 8 },
			new PointStructOne() { X = 17, Y = 15 },
			new PointStructOne() { X = 18, Y = 9 }
		};

		private PointStructTwo[] _arrayForPointStructTwo =
		{
			new PointStructTwo() { X = 22, Y = 14 },
			new PointStructTwo() { X = 6, Y = 4 },
			new PointStructTwo() { X = 7, Y = 3 },
			new PointStructTwo() { X = 8, Y = 2 }
		};

		private PointStructOne[] _arrayForPointStructOneD =
		{
			new PointStructOne() { pX = 42, pY = 34 },
			new PointStructOne() { pX = 10, pY = 8 },
			new PointStructOne() { pX = 17, pY = 15 },
			new PointStructOne() { pX = 18, pY = 9 }
		};

		private PointStructTwo[] _arrayForPointStructTwoD =
		{
			new PointStructTwo() { pX = 22, pY = 14 },
			new PointStructTwo() { pX = 6, pY = 4 },
			new PointStructTwo() { pX = 7, pY = 3 },
			new PointStructTwo() { pX = 8, pY = 2 }
		};

		private float PointDistance(PointClassOne pointOne, PointClassTwo pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return MathF.Sqrt((x * x) + (y * y));
		}

		private float PointDistance(PointStructOne pointOne, PointStructTwo pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return MathF.Sqrt((x * x) + (y * y));
		}

		private double PointDistanceD(PointStructOne pointOne, PointStructTwo pointTwo)
		{
			double x = pointOne.pX - pointTwo.pX;
			double y = pointOne.pY - pointTwo.pY;
			return Math.Sqrt((x * x) + (y * y));
		}

		private float PointDistanceNoSqrt(PointStructOne pointOne, PointStructTwo pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return (x * x) + (y * y);
		}

		[Benchmark]
		public void TestPointDistance()
		{
			for (int i = 0; i < _arrayForPointClassOne.Length; i++)
				PointDistance(_arrayForPointClassOne[i], _arrayForPointClassTwo[i]);
		}

		[Benchmark]
		public void TestPointDistanceForStruct()
		{
			for (int i = 0; i < _arrayForPointStructOne.Length; i++)
				PointDistance(_arrayForPointStructOne[i], _arrayForPointStructTwo[i]);
		}

		[Benchmark]
		public void TestPointDistanceD()
		{
			for (int i = 0; i < _arrayForPointStructOneD.Length; i++)
				PointDistanceD(_arrayForPointStructOneD[i], _arrayForPointStructTwoD[i]);
		}

		[Benchmark]
		public void TestPointDistanceNoSqrt()
		{
			for (int i = 0; i < _arrayForPointStructOne.Length; i++)
				PointDistanceNoSqrt(_arrayForPointStructOne[i], _arrayForPointStructTwo[i]);
		}
	}
}
