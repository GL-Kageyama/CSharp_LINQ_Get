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
            var getClass = new GetClass();

            getClass.GetArray();

            getClass.GetList();
        }
    }

    class GetClass
    {
        public void GetArray()
        {
            var source = new[] {2, 3, 1, 7, 8, 9, 28, 98};

            // ElementAt()
            // Get the value of the specified index
            Console.WriteLine(source.ElementAt(3));

            // ElementAtOrDefault()
            // Get the value of the specified index, or get the specified value if it is out of range
            Console.WriteLine(source.ElementAtOrDefault(100));

            // First()
            // Get the first element
            Console.WriteLine(source.First());

            // First()
            // Get the first element greater than 10
            Console.WriteLine(source.First(s => s > 10));

            // Last()
            // Get the last element
            Console.WriteLine(source.Last());

            // Last()
            // Get the last element that is less than 20
            Console.WriteLine(source.Last(s => s < 20));

            // Single()
            // Retrieve the only element (only possible if it is the only one that applies)
            Console.WriteLine(source.Single(s => s < 2));

            Console.WriteLine();
        }

        public void GetList()
        {
            List<string> state = new List<string>
            {
                "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", 
                "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", 
            };

            List<int> intList = new List<int> 
            {
                22, 34, 22, 67, 56, 98, 65, 78, 22, 67, 98, 98, 98
            };

            // Where()
            // Obtain all that apply
            IEnumerable<string> query = state.Where(x => x.Length > 5);
            foreach (string ken in query)
                Console.WriteLine(ken);
            Console.WriteLine();

            // Distinct()
            // Get duplicates removed
            IEnumerable<int> distinctInt = intList.Distinct();
            foreach (int intOut in distinctInt)
                Console.WriteLine(intOut);
            Console.WriteLine();

            // Skip()
            // Skip a specified number
            IEnumerable<int> skipInt = intList.Skip(8);
            foreach (int intOut in skipInt)
                Console.WriteLine(intOut);
            Console.WriteLine();

            // Take()
            // Get the specified element from the top
            IEnumerable<int> takeInt = intList.Take(6);
            foreach (int intOut in takeInt)
                Console.WriteLine(intOut); 
        }
    }
}