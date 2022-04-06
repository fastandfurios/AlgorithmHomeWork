using System;
using BenchmarkDotNet.Running;

namespace Lesson3
{
	public class Program
	{
		static void Main(string[] args)
		{
			BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
		}
	}
}
