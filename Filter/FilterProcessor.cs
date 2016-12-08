using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer.Filter.ExpressionTree
{
    class FilterProcessor
    {
        private Func<String[], Boolean> filter;

        public Func<String[], Boolean> CreateFilter(String filter)
        {
            this.filter = new ExpressionTreeCreator(filter).CreateLambda();
            return this.filter;
        }
    }
}
