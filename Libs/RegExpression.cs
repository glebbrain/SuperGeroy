using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SuperGeroy.Libs
{
    class RegExpression
    {
        public static List<string> GetStringBetweenTwoStrings(string enter, string first, string second)
        {
            List<string> s = new List<string>();
            Regex r = new Regex(first + @"(.*?)" + second);
            MatchCollection mc = r.Matches(enter);
            if (mc!=null && mc.Count>0)
            {
                foreach (Match m in mc)
                {
                    s.Add(m.Value);
                }
            }
            return s;
        }
    }
}
