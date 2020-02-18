using System;
using System.Collections.Generic;

namespace Lecture_Code
{ 
 
	public class Program
	{
		public static void Main()
		{

			//Dictionary's are collections of a key/value pairs - just strongly typed. They can be of any type(int, string, bool, custom, etc).

			////How to make a dictionary in C#///
			////////////////////////////////////
			//makes a dictionary named 'toysSold' and adds key 
			//////////////////////////////////////value pairs at the sane time, you can also make an empty dictionary and use nameOfDictionary.Add(Key, Value)
			Dictionary<string, int> candySold = new Dictionary<string, int>() {
					{"Reeses", 200},
					{"Snickers", 155},
					{"Twix", 139},
					{"Skittles", 100}
				};
			//////////////////////////////////////////////////////////////////////////////////////////
			////how to use .Add(Key, Value) to add KeyValuePairs to the dictionary named "toysSold"///
			//////////////////////////////////////////////////////////////////////////////////////////
			//  "GI Joe" = Key   and   430 = Value || together they make a KeyValuePair
			candySold.Add("Sour Patch Kids", 98);
				//access and print this newly added Value(430) to the console by using the key of "GI Joe"
				Console.WriteLine(candySold["Sour Patch Kids"]);


				////////////////////////////////////////////////////////////////////////
				////How to loop over the dictionary and print each toy & its price/////
				///////////////////////////////////////////////////////////////////////
				Console.WriteLine("****candySold Dictionary****");//title of list you are about to print
				foreach (KeyValuePair<string, int> candy in candySold)
				{
					Console.WriteLine($"{candy.Key} made ${candy.Value}");
				}



				//now lets make anither Dictionary that contains your top 5 video games, rank 1-5 would be of type 'int', and the name of the game would be type 'string'		
				////////////////////////////////////////////
				////How to make an empty dictionary in C#///
				////////////////////////////////////////////
				Dictionary<double, string> top5States = new Dictionary<double, string>();

				//now we have an empty dictionary called 'top5VideoGames, lets add some games with .Add() instead of using {key, value} after creating te Dictionary like the first dictionary we created      
				top5States.Add(8.8, "Florida");
				top5States.Add(8.6, "New York");
				top5States.Add(7.1, "California");
				top5States.Add(6.7, "Texas");
				top5States.Add(5.8, "Tennessee");

				//Now lets loop over the dictionary and print each key value pair to the Console
				//First lets print a title to the console
				Console.WriteLine("****Top 5 States****");
				//loop over Dictionary and print each one
				foreach (KeyValuePair<double, string> game in top5States)
				{
					Console.WriteLine(game.Key + " " + game.Value);
				}


				//how to check if an int(key) is in the dictionary -- here we check if the Dictionary has a key of 3
				Console.WriteLine("***How to check if a certain key exists in a dictionary with an if-else statement***");
				//create an empty variable
				string value;
				if (top5States.ContainsKey(1))
				{
					value = top5States[1];
					Console.WriteLine($"{value} exists in the dictionary");
				}
				else
				{
					Console.WriteLine("Key Not Present");
					return;
				}

			}
		}
}
