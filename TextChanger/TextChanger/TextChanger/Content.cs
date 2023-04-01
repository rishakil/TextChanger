using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextChanger
{
    internal class Content
    {
        internal string RetrieveContent(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            return content;
            reader.Close();
        }
        internal void CountWord(string _filepath)
        {
            try
            {
                StreamReader reader = new StreamReader(_filepath);
                using (reader)
                {
                    var count = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        var words = line.Split(' ', '?', '.', ',', '!');
                        foreach (var word in words)
                        {
                            if (word != "") count++;
                        }
                        line = reader.ReadLine();
                    }
                    Console.WriteLine("Number of words in the file is: " + count);
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("File not found at {0}.", _filepath);
            }
        }
    }
}
