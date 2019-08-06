using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ_Get
{
	class MainClass 
	{
		public static void Main(string[] args)
		{
			var GetObj = new GetClass();

			GetObj.GetArray();

			GetObj.GetList();
		}
	}

	class GetClass
	{
		public void GetArray()
		{
			var source = new[] {2, 3, 1, 7, 8, 9, 28, 98};

			// ElementAt()
			// 指定したIndexの値を取得
			Console.WriteLine(source.ElementAt(3));

			// ElementAtOrDefault()
			// 指定したIndexの値を取得、範囲外の場合は規定値を取得
			Console.WriteLine(source.ElementAtOrDefault(100));

			// First()
			// 最初の要素を取得
			Console.WriteLine(source.First());

			// First()
			// 10より大きい最初の要素を取得
			Console.WriteLine(source.First(s => s > 10));

			// Last()
			// 最後の要素を取得
			Console.WriteLine(source.Last());

			// Last()
			// 20より小さい最後の要素を取得
			Console.WriteLine(source.Last(s => s < 20));

			// Single()
			// 唯一の要素を取得(該当したものが唯一の時のみ取得可)
			Console.WriteLine(source.Single(s => s < 2));
		}

		public void GetList()
		{
			List<string> Pre = new List<string>
			{
				"Kanagawa", "Kyoto", "Gihu", "Okayama", "Yamaguchi", 
				"Aomori", "Nagano", "Okinawa", "Saitama", "Iwate", 
			};

			List<int> integer = new List<int> 
			{
				22, 34, 22, 67, 56, 98, 65, 78, 22, 67, 98, 98, 98
			};

			// Where()
			// 該当するものを全て取得
			IEnumerable<string> query = Pre.Where(x => x.Length > 5);
			foreach (string ken in query)
				Console.WriteLine(ken);

			// Distinct()
			// 重複を取り除いたものを取得
			IEnumerable<int> distinctInt = integer.Distinct();
			foreach (int intOut in distinctInt)
				Console.WriteLine(intOut);
			Console.WriteLine();

			// Skip()
			// 指定した数をスキップ
			IEnumerable<int> skipInt = integer.Skip(8);
			foreach (int intOut in skipInt)
				Console.WriteLine(intOut);
			Console.WriteLine();

			// Take()
			// 先頭から指定した要素を取得
			IEnumerable<int> takeInt = integer.Take(6);
			foreach (int intOut in takeInt)
				Console.WriteLine(intOut); 
		}
	}
}

