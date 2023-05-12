using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextChanger
{
    internal class Intro
    {
        internal void Options()
        {
            Console.Write("What would you like to get addressed as? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello "+ name + "!");
            Console.Write("Please choose any option: ");
            Console.WriteLine("   1. Total word count in your file\n   2. Change specific all words in your file\n   3. Frequency of a specific word in your file ");
            Console.Write("Your option: ");
            var option = Console.ReadLine();

            
            TextFile textFile = new TextFile();
            Console.Write("Name of the file (like --> filename.txt: ");
            textFile.Name = Console.ReadLine();
            Console.Write("Directory path of the file: ");
            textFile.Path = Console.ReadLine();
            string FullPath = Path.Combine(textFile.Path, textFile.Name);

            if(option == "1")
            {
                Content content = new Content();
                content.CountWord(FullPath);
            }
            else if(option == "2")
            {

            }
        }
    }
}
