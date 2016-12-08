using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer.Filter.ReversePolishNotation
{
    class ReversePolishNotation : SymbolsPriority
    {
        private static Stack<String> stack;
        private static List<Object> polandList;

        public static List<Object> CreatePolandList(String[] words, List<String> filterList) //Words - массив слов файла, в котором мы ищем значение
        {
            stack = new Stack<String>();
            polandList = new List<Object>();
            polandList.Clear();
            foreach (String value in filterList)
            {
                if (Array.IndexOf(OPERATORS, value) == -1) //If current token is not a operator, put Value.FindInText in polandList
                    polandList.Add(TextParser.Parser.FindInText(value, words));
                else if ((!value.Equals(OPERATORS[CLOSE_BRACKET])) && (!value.Equals(OPERATORS[OPEN_BRACKET])))
                    stack.Push(value);

                if (value.Equals(OPERATORS[CLOSE_BRACKET])) //If current token was in filterList, then clean-up stack
                    CleanUpStack();
            }
            CleanUpStack();
            return polandList;
        }

        private static void CleanUpStack()
        {
            String value;
            while (stack.Count != 0)
            {
                value = stack.Pop();
                polandList.Add(value);
            }
        }
    }
}
