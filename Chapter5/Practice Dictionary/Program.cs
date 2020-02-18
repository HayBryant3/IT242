using System;
using System.Collections.Generic;

namespace Practice_Dictionary

{
    public class Program
    {
        public static void Main()
        {
            /*
                      Create a dictionary with key value pairs to
                      represent words (key) and its definition (value)
              */
          
            Dictionary<int, string> wordsAndDefinitions = new Dictionary<int, string>(){
                {1, "a hand tool with a handle and a head."},
                {2, "a metal piece with indentions to twist and tighten items with."},
                {3, "a metal piece that is hammered to be made into a fastener."}
            };

            // Add several more words and their definitions
            wordsAndDefinitions.Add(4, "a blade of metal used to cut.");
            wordsAndDefinitions.Add(5, "tool used for loosening and tightening screws.");
            wordsAndDefinitions.Add(6, "a gripping tool that makes the user's hand force stronger.");
           





            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */

            // you can use nameOfDictionary[key] to search your dictionary and grab the value of the key, here 'bitcoin' is the key and 'magic internet money is the value'
            //first make a title so you can easily keep track of values you are printing to the console.
            Console.WriteLine("Returns the value(defintion) of the key specified, ex: nameOfDictionary[key]");
            
          

            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            Console.WriteLine("Tools");
            foreach (KeyValuePair<int, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($" -{word.Key}- Definition: {word.Value}");
            }
        }
    }
}