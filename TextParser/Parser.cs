using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer.TextParser
{
    class Parser
    {
        private string text;

        public Parser(String filePath)
        {
            text = openFile(filePath);
        }

        private string openFile(string filePath)
        {
            string text = "";
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found.");
            text = File.ReadAllText(filePath, Encoding.Default);
            return text;
        }

        public string[] SplitOnWords()
        {
            char[] punctuationMarks = { ' ', ',', ':', '?', '!', ';' };
            return text.Split(punctuationMarks, StringSplitOptions.RemoveEmptyEntries);
        }

        public static Boolean FindInText(String word, String[] words)
        {
            if (Array.IndexOf(words, word) != -1)
                return true;
            else
                return false;
        }
    }
}
