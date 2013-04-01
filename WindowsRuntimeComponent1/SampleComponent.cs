using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleComponent
{
    public sealed class Example
    {
        public static string GetAnswer()
        {
            return "The answer is 42.";
        }

        public int SampleProperty { get; set; }

        public static IDictionary<int, string> GetMapOfNames()
        {
            Dictionary<int, string> retval = new Dictionary<int, string>();
            retval.Add(1, "one");
            retval.Add(2, "two");
            retval.Add(3, "three");
            retval.Add(42, "forty-two");
            retval.Add(100, "one hundred");
            return retval;
        }
    }
}