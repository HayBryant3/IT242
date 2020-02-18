using System;
using System.Collections.Generic;

namespace ExtraCredit
{

	public class Program
	{
		public static void Main()
		{
			//Create a sorted list and add some keyValuePairs
			SortedList<int, string> sortedList1 = new SortedList<int, string>();
			sortedList1.Add(3, "Three");
			sortedList1.Add(4, "Four");
			sortedList1.Add(1, "One");
			sortedList1.Add(5, "Five");
			sortedList1.Add(2, "Two");

			//How to count how many keyValuePairs are in a sorted list
			Console.WriteLine("sortedList1 has " + sortedList1.Count + " items in the list");
			//for extra credit loop over the list and print the SortedList to the Console
			for (int i = 0; i < sortedList1.Count; i++)
			{
				Console.WriteLine("key: {0}, value: {1}", sortedList1.Keys[i], sortedList1.Values[i]);
			}
		
			{
				//add code here to console.WriteLine each items key and value
				//notice how the SortedList automatically sorts all keyValuePairs by the key, 
				//either alphabetically or by number depending on the keys type, here the keys are of type int
				//HINT: look below where I loop over sortedList2 and sortedList3
			}


			SortedList<string, int> sortedList2 = new SortedList<string, int>();
			sortedList2.Add("one", 1);
			sortedList2.Add("two", 2);
			sortedList2.Add("three", 3);
			sortedList2.Add("four", 4);
			// Compile time error: cannot convert from <null> to <int>
			//sortedList2.Add("Five", null);

			//How to count how many items are in a sorted list2
			Console.WriteLine("sortedList2 has " + sortedList2.Count + " items in the list");

			//Loop over sortedList2 with a regular 'for loop', see sortedList3 below for a 'foreach' loop, you can use either one to loop over sortedList1 for extra credit
			//Hint: copy and paste this above and change sortedList2 -> sortedList1
			for (int i = 0; i < sortedList2.Count; i++)
			{
				Console.WriteLine("key: {0}, value: {1}", sortedList2.Keys[i], sortedList2.Values[i]);
			}






			//the ? after int lets us add in null values, without the ? it will say "cannot convert from <null> to <int>" and will not work
			//creates a sorted list with keyValuePairs
			SortedList<double, int?> sortedList3 = new SortedList<double, int?>()
		{
				{1.2, null},
				{3.6, 400},
				{7.1, 701}
		};
			//adds more keyValuePairs with .Add()
			sortedList3.Add(1.5, 100);
			sortedList3.Add(3.5, 200);
			sortedList3.Add(2.4, 300);
			sortedList3.Add(2.3, null);
			sortedList3.Add(1.1, null);



			//How to count how many items are in a sorted list 3
			Console.WriteLine("sortedList3 has " + sortedList3.Count + " items in the list");

			//How to loop over the sortedList3
			foreach (KeyValuePair<double, int?> kvp in sortedList3)
			{
				Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

			}

		}
	}
}