using System.Collections.Generic;
using System.Linq;
using System;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
		{
			List<int> elements = new List<int>()
		{ 1,2,3,4,5,6,7,8,9,};

			var Intlist = elements.Where(obj => obj % 2 == 0).ToList();

			foreach (var i in Intlist)
			{
				Console.WriteLine(i);
			}
			Console.ReadKey();
		}
	}
}
