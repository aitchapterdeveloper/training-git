using System;
using System.Collections.Generic;
using System.Linq;
class LINQService
{
	public void PrintNumberList(List<int> numbers)
	{
		foreach (var n in numbers)
		{
			if (n > 10)
			{
				Console.WriteLine(n.ToString());
			}
		}
	}

	public void PrintNumberListWithLINQ(List<int> numbers)
	{
		//boleh ga urut
		var queryResult = numbers
			.Where(n => n > 10)
			.Select(n => n)
			.OrderByDescending(n => n);

		numbers.Add(20);

		//harus urutan
		var queryResult2 = from n in numbers
			where n > 10
			orderby n descending
			select n;
		Console.WriteLine("Late");

		foreach (var n in queryResult)
		{
			Console.Write(n.ToString() + ", ");
		}
		Console.WriteLine("");
	}

	public void PrintListAggregate(List<int> numbers)
	{
		Console.WriteLine(numbers.Count(n => n > 10));
		Console.WriteLine(numbers.Sum());
		Console.WriteLine(numbers.Average(n => n));
		Console.WriteLine(numbers.Any(n => n > 10));
		Console.WriteLine(numbers.All(n => n > 10));
	}

	public List<int> ProcessListWithLINQ(List<int> numbers)
	{
		var queryResult = numbers
			.Where(n => n > 10)
			.Select(n => n)
			.OrderByDescending(n => n)
			.ToList();

		numbers.Add(20);
		return queryResult;
	}
}