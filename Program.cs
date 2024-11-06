using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("enter a sentence");
                String sentence = Console.ReadLine();  //take the sentence
            if (sentence == "")       // sentence should type
            {
                Console.WriteLine("should write something");

            }
            else
            {
                string[] words = sentence.Split(' ');  //split sentence
                int wordcount = words.Length;
                Console.WriteLine("number of words in the sentence is:" + wordcount);//count the word
            }
            Console.ReadLine();
                 
            
            
        }
    }
}
