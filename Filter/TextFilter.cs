using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyzer.Filter.ExpressionTree;
using TextAnalyzer.Interface;

namespace TextAnalyzer.Filter
{
    public class TextFilter : IFilter
    {
        private Func<String[], Boolean> filter;

        public TextFilter(string filter)
        {
            FilterProcessor filterProcessor = new FilterProcessor();
            this.filter = filterProcessor.CreateFilter(filter);
        }

        public Boolean Verify(String[] words)
        {
            if (filter == null)
                throw new NullReferenceException("Filter is not initialized");
            if (words == null)
                throw new ArgumentNullException("Words can not be null.");
            return filter.Invoke(words);
        }
    }
}
