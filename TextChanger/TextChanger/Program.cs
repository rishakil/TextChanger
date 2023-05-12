using System;
using System.IO;
using System.Text.RegularExpressions;
namespace TextChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello there! What's your name? ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Intro intro = new Intro();
            var option = intro.Options();
            Action action = new Action();
            action.Perform(option);
        }
    }
}