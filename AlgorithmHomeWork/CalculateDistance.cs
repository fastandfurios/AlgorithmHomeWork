using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson3
{
	public class CalculateDistance
	{
		[Benchmark]
		public float PointDistance(PointClassOne pointOne, PointClassTwo pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return MathF.Sqrt((x * x) + (y * y));
		}

		[Benchmark]
		public float PointDistance(PointStructOne pointOne, PointStructTwo pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return MathF.Sqrt((x * x) + (y * y));
		}

		[Benchmark]
		public double PointDistanceD(PointStructOne pointOne, PointStructTwo pointTwo)
		{
			double x = pointOne.pX - pointTwo.pX;
			double y = pointOne.pY - pointTwo.pY;
			return Math.Sqrt((x * x) + (y * y));
		}

		[Benchmark]
		public float PointDistanceNoSqrt(PointStructOne pointOne, PointStructTwo pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return (x * x) + (y * y);
		}
	}
}
