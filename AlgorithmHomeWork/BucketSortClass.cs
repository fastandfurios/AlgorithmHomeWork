using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class BucketSortClass
    {
	    private List<int> _sort;
	    private readonly int[] _array;

	    public void Run()
	    {
		    _sort = Sort(_array);

		    foreach (var item in _sort)
			    Console.Write($"{item} ");
		}

		public List<int> Sort(params int[] array)
		{
			if (array != null)
			{
				List<int> sortedList = new List<int>();

				int numberOfBuckets = 10;

				List<int>[] buckets = new List<int>[numberOfBuckets];

				for (int i = 0; i < numberOfBuckets; i++)
					buckets[i] = new List<int>();

				for (int i = 0; i < array.Length; i++)
				{
					int bucket = (array[i] / numberOfBuckets);
					buckets[bucket].Add(array[i]);
				}

				for (int i = 0; i < numberOfBuckets; i++)
				{
					List<int> temp = InsertionSort(buckets[i]);
					sortedList.AddRange(temp);
				}

				return sortedList;
			}
			else
				throw new NullReferenceException();
		}

		public List<int> InsertionSort(List<int> bucket)
		{
			for (int i = 1; i < bucket.Count; i++)
			{
				int currentValue = bucket[i];
				int pointer = i - 1;

				while (pointer >= 0)
				{
					if (currentValue < bucket[pointer])
					{
						bucket[pointer + 1] = bucket[pointer];
						bucket[pointer] = currentValue;
					}
					else
						break;
				}
			}

			return bucket;
		}
	}
}
