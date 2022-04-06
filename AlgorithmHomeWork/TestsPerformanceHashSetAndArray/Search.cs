using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Lesson4.TestsPerformanceHashSetAndArray
{
    public class Search
    {
	    private string[] _array;
	    private readonly HashSet<string> _hashSet = new HashSet<string>();

	    protected Search() => SetArrayAndHashSet();

	    private void SetArrayAndHashSet()
	    {
		    int length = 10000;
		    _array = new string[length];

		    for (int i = 0; i < _array.Length; i++)
		    {
			    if (i == 9998)
			    {
				    _array[i] = "привет";
				    _hashSet.Add("привет");
				}
			    _array[i] = Guid.NewGuid().ToString();
			    _hashSet.Add(Guid.NewGuid().ToString());
		    }
	    }

	    [Benchmark]
	    public void TestSearchValueArray()
	    {
		    foreach (var item in _array)
		    {
			    if(item.Equals("привет"))
					return;
		    }
	    }

		[Benchmark]
	    public void TestSearchValueHashSet()
	    {
		    foreach (var item in _hashSet)
		    {
			    if(item.Equals("привет"))
					return;
		    }
	    }

		[Benchmark]
	    public void TestSearchValueHashSetWithContains()
	    {
			if(_hashSet.Contains("привет"))
				return;
	    }
    }
}
