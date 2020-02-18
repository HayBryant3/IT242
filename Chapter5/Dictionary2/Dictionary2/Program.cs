using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Dictionary2
{
    class Program
    {
        public static void Main()
        {

            // Make a new empty List, we will be creating a List of Dictionary's
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();



            //create an empty Dictionary named 'excited' then use .Add to insert some key/value pairs, we will add this to the empty list called 'dictionaryOfWords'
            Dictionary<string, string> strawberry = new Dictionary<string, string>();

            strawberry.Add("word", "strawberry");
            strawberry.Add("definition", "sweet, red, seeded fruit");
            strawberry.Add("part of speech", "noun");
            strawberry.Add("example sentence", "I want to eat a strawberry!");

            dictionaryOfWords.Add(strawberry);



            Dictionary<string, int> bitcoin = new Dictionary<string, int>();

            bitcoin.Add("word", 1);
            bitcoin.Add("definition", 2);
            bitcoin.Add("part of speech", 3);
            bitcoin.Add("example sentence", 4);

            foreach (KeyValuePair<string, int> word in bitcoin)
            {

                Console.WriteLine($"{word.Key}: {word.Value} ");
            }

            Dictionary<string, string> computers = new Dictionary<string, string>();

            computers.Add("word", "computers");
            computers.Add("definition", "boxes for data");
            computers.Add("part of speech", "noun");
            computers.Add("example sentence", "I am excited to computer");



            dictionaryOfWords.Add(computers);

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
               {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few word
            // Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            // excitedWord.Add();

            // Add Dictionary to your `dictionaryOfWords` list


            // create another Dictionary and add that to the list


            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries with a foreach loop inside another foreach loop
            //a foreach loop inside another foreach loop
            foreach (Dictionary<string, string> list in dictionaryOfWords)
            {

                Console.WriteLine("------");
                foreach (KeyValuePair<string, string> word in list)
                {

                    Console.WriteLine($"{word.Key}: {word.Value} ");
                }
            }


        }
    }
}
