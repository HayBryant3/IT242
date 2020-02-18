using System;
using System.Collections.Generic;

namespace Idioms
{
    class Program
    {
        public static void Main()
        {
            //List in C# is similar to an array, 
            //This is a dictionary that is of type 'string' and type 'List', the key is the 'string' and the value is a 'List" of type 'strings'
            //ex: "Penny" = idioms[0].key
            Dictionary<int, List<string>> idioms = new Dictionary<int, List<string>>();
            idioms.Add(1, new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add(2, new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add(3, new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add(4, new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add(5, new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add(6, new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add(7, new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add(8, new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add(9, new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add(10, new List<string> { "Speak", "of", "the", "devil" });


            //This is how you access and loop through a single item in the dictionary 'idioms' 
            //will pirint every word(value) in list with key of "Moon"
            foreach (string value in idioms[4])
            {
                Console.WriteLine(value);
            }


            //this is to put a space between the words so the sentence is readable
   

            //Loop through the Dictionary with foreach and use .Join() to combine all the words in the 
            foreach (int key in idioms.Keys)

            {
              
            
            }
        }
    }
}
