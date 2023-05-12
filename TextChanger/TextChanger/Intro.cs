using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextChanger
{
    public class Intro
    {
        internal string Options()
        {
            Console.Write("Please choose any option: \n");
            Console.WriteLine("   1. Total word count in your file\n   2. Change specific all words in your file\n   3. Frequency of a specific word in your file\n   4. Close this console");
            Console.Write("Your option: ");
            var option = Console.ReadLine();
            return option;
        }
    }
}
