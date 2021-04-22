using System;
using System.Reflection;
using BenchmarkDotNet.Attributes;

namespace Lesson3
{
	public class CalculateDistance
	{
		private readonly Random _random = new Random();
		private PointClassOne[] _arrayForPointClassOne;
		private PointClassTwo[] _arrayForPointClassTwo;
		private PointStructOne[] _arrayForPointStructOne;
		private PointStructTwo[] _arrayForPointStructTwo;
		private PointStructOne[] _arrayForPointStructOneD;
		private PointStructTwo[] _arrayForPointStructTwoD;

		protected CalculateDistance() => SetArrays();

		private void SetArrays()
		{
			int size = 100;
			_arrayForPointClassOne = new PointClassOne[size];
			_arrayForPointClassTwo = new PointClassTwo[size];
			_arrayForPointStructOne = new PointStructOne[size];
			_arrayForPointStructTwo = new PointStructTwo[size];
			_arrayForPointStructOneD = new PointStructOne[size];
			_arrayForPointStructTwoD = new PointStructTwo[size];

			for (int i = 0; i < _arrayForPointStructOne.Length; i++)
			{
				_arrayForPointClassOne[i] = new PointClassOne()
				{
					X = _random.Next(0, size),
					Y = _random.Next(0, size)
				};
				_arrayForPointClassTwo[i] = new PointClassTwo()
				{
					X = _random.Next(0, size),
					Y = _random.Next(0, size)
				};
				_arrayForPointStructOne[i] = new PointStructOne()
				{
					X = _random.Next(0, size),
					Y = _random.Next(0, size)
				};
				_arrayForPointStructTwo[i] = new PointStructTwo()
				{
					X = _random.Next(0, size),
					Y = _random.Next(0, size)
				};
				_arrayForPointStructOneD[i] = new PointStructOne()
				{
					pX = _random.Next(0, size),
					pY = _random.Next(0, size)
				};
				_arrayForPointStructTwoD[i] = new PointStructTwo()
				{
					pX = _random.Next(0, size),
					pY = _random.Next(0, size)
				};
			}
		}

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
