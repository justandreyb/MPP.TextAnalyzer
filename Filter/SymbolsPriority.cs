using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer.Filter
{
    public abstract class SymbolsPriority
    {
        protected static readonly String[] OPERATORS = { "NOT", "AND", "OR", "(", ")" };
        protected const Char FILTER_SPLITTER = '@';
        protected const byte NOT_INDEX = 0;
        protected const byte AND_INDEX = 1;
        protected const byte OR_INDEX = 2;
        protected const byte OPEN_BRACKET = 3;
        protected const byte CLOSE_BRACKET = 4;
    }
}
