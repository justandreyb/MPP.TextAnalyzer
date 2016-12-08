using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyzer.Filter;
using TextAnalyzer.TextParser;

namespace TextAnalyzer.ExampleUsing
{
    class Program
    {
        public static void Main()
        {
            TextFilter filter = new TextFilter("");
            Parser parser = new Parser("filePath");
            bool result = filter.Verify(parser.SplitOnWords());

            Console.WriteLine(result);
        }
    }
}
