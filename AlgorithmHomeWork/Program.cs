using System;
using Lesson4.TestsPerformanceHashSetAndArray;
using BenchmarkDotNet.Running;


namespace Lesson4
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
		}
	}
}
