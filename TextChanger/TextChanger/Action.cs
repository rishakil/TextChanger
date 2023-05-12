using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextChanger
{
    internal class Action
    {
        public void Repeat()
        {
            TextFile textFile = new TextFile();
            Intro intro = new Intro();
            Console.Write("Want to continue? y/n: ");
            var opt = Console.ReadLine();
            if (opt == "y")
            {
                var option = intro.Options();
                Action action = new Action();
                action.Perform(option);
            }
            else Console.WriteLine("Thank you!");
        }
        public void Perform(String _option)
        {
            TextFile textFile = new TextFile();
            Intro intro = new Intro();

            if (_option == "1")
            {
                Console.Write("Name of the file (like --> filename.txt: ");
                textFile.Name = Console.ReadLine();
                Console.Write("Directory path of the file: ");
                textFile.Path = Console.ReadLine();
                var FullPath = Path.Combine(textFile.Path, textFile.Name);
                Content content = new Content();
                content.CountWord(FullPath);
                Repeat();
            }
            else if (_option == "2")
            {
                Console.Write("Name of the file (like --> filename.txt: ");
                textFile.Name = Console.ReadLine();
                Console.Write("Directory path of the file: ");
                textFile.Path = Console.ReadLine();
                var FullPath = Path.Combine(textFile.Path, textFile.Name);
                Console.Write("Please enter the current word: ");
                var OldWord = Console.ReadLine();
                Console.Write("Please enter the new word: ");
                var NewWord = Console.ReadLine();
                string content = textFile.Modify(FullPath, OldWord, NewWord);
                Console.WriteLine("Please wait...");
                StreamWriter writer = new StreamWriter(FullPath);
                writer.Write(content);
                Console.WriteLine("File has been modified successfully!");
                writer.Close();
                Repeat();
            }
            else if (_option == "3")
            {
                Console.WriteLine("Sorry for the inconvenience. This feature is coming soon!");
                Repeat();
            }
            else if (_option == "4") Console.WriteLine("Thank you!");
            else
            {
                Console.WriteLine("You have opted Invalid option");
                Repeat();
            }

        }
    }
}
