﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TextChanger
{
    internal class TextFile : Content
    {
        internal string? Name { get; set; }
        internal string? Path { get; set; }
        public string Modify(string _filepath, string oldtext, string newtext)
        {
            string _content = RetrieveContent(_filepath);
            string content = Regex.Replace(_content, oldtext, newtext);
            return content;
        }
    }
}
