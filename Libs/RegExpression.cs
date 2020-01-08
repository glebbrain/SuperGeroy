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
        #region Data
        public static List<string> StandartPatterns(string name)
        {
            List<string> ps = new List<string>();
            if (name == "email")
            {
                // easy regex:
                ps.Add(@"[A-Za-z]+[\.A-Za-z0-9_-]*[A-Za-z0-9]+@[A-Za-z]+\.[A-Za-z]+");
                // site: https://emailregex.com/
                //ps.Add("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\x01 -\x08\x0b\x0c\x0e -\x1f\x21\x23 -\x5b\x5d -\x7f] |\\[\x01 -\x09\x0b\x0c\x0e -\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\\])");
            }
            else if (name == "telephone")
            {
                // site: http://phoneregex.com/
                // Russian
                //ps.Add(@"((\+7|7|8)+([0-9]){10})");
                //ps.Add(@"(\+7|7|8)?[\s\-]?\(?[489][0-9]{2}\)?[\s\-]?[0-9]{3}[\s\-]?[0-9]{2}[\s\-]?[0-9]{2}");
                //ps.Add(@"([\(]?[+]{1}[0-9]{1,3}[\)]?[ .\-]?)?[\(]?[0-9]{3}[\)]?[ .\-]?([0-9]{3}[ .\-]?[0-9]{4}|[a-zA-Z0-9]{7})([ .\-]?[/]{1}[ .\-]?[0-9]{2,4})?");
                // Generic International Phone Number
                //ps.Add(@"\+(9[976]\d|8[987530]\d|6[987]\d|5[90]\d|42\d|3[875]\d|2[98654321]\d|9[8543210]|8[6421]|6[6543210]|5[87654321]|4[987654310]|3[9643210]|2[70]|7|1)\d{1,14}");
                // US & Canada
                //ps.Add(@"1?\W*([2-9][0-8][0-9])\W*([2-9][0-9]{2})\W*([0-9]{4})(\se?x?t?(\d*))?");
                //ps.Add(@"(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?");
                // UK
                //ps.Add(@"(?:(?:\(?(?:0(?:0|11)\)?[\s-]?\(?|\+)44\)?[\s-]?(?:\(?0\)?[\s-]?)?)|(?:\(?0))(?:(?:\d{5}\)?[\s-]?\d{4,5})|(?:\d{4}\)?[\s-]?(?:\d{5}|\d{3}[\s-]?\d{3}))|(?:\d{3}\)?[\s-]?\d{3}[\s-]?\d{3,4})|(?:\d{2}\)?[\s-]?\d{4}[\s-]?\d{4}))(?:[\s-]?(?:x|ext\.?|\#)\d{3,4})?");
                // Germany
                ps.Add(@"([\+][0-9]{1,3}[ \.\-])?([\(]{1}[0-9]{1,6}[\)])?([0-9 \.\-\/]{3,20})((x|ext|extension)[ ]?[0-9]{1,4})?");
                // China
                //ps.Add(@"(13[0-9]|14[57]|15[012356789]|17[0678]|18[0-9])[0-9]{8}");
                //ps.Add(@"1[34578][012356789]\d{8}|134[012345678]\d{7}");
                // Japan
                //ps.Add(@"((\+*)(0*|(0 )*|(0-)*|(91 )*)(\d{12}+|\d{10}+))|\d{5}([- ]*)\d{6}");
                //ps.Add(@"((\+*)((0[ -]+)*|(91 )*)(\d{12}+|\d{10}+))|\d{5}([- ]*)\d{6}");
                // Indonesia
                //ps.Add(@"\(?(?:\+62|62|0)(?:\d{2,3})?\)?[ .-]?\d{2,4}[ .-]?\d{2,4}[ .-]?\d{2,4}");
                // Brazil
                //ps.Add(@"(^|\()?\s*(\d{2})\s*(\s|\))*(9?\d{4})(\s|-)?(\d{4})($|\n)");
            }
            else if (name == "url")
            {
                // site: https://urlregex.com/
                ps.Add(@"(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)");
            }
            else if (name == "ip")
            {
                ps.Add(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            }
            return ps;
        }
        #endregion


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

        public static string FindStandartPattern(string text, string patternRegEx, bool SuperTestEnabled=false)
        {
            string find = "";
            MatchCollection matches = null;
            List<string> ps = StandartPatterns(patternRegEx);
            
            // перебираем все паттерны по данному типу информации
            foreach (string p in ps)
            {
                if (SuperTestEnabled)
                {
                    find += "Паттерн: " + p + "" + Environment.NewLine;
                }
                matches = Regex.Matches(text, p, RegexOptions.Multiline | RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.ECMAScript);
                if (matches != null && matches.Count > 0)
                {
                    foreach (var m in matches)
                    {
                        if (!String.IsNullOrEmpty(find))
                        {
                            find += Environment.NewLine;
                        }

                        find += m.ToString();
                    }
                }
                if (SuperTestEnabled)
                {
                    find += Environment.NewLine + "----" + Environment.NewLine;
                }
            }
            return find;
        }


        public static string ReplaceStandartPattern(string text, string patternRegEx, string replace, bool SuperTestEnabled = false)
        {
            string find = "";
            MatchCollection matches = null;
            List<string> ps = StandartPatterns(patternRegEx);
            // перебираем все паттерны по данному типу информации
            foreach (string p in ps)
            {
                if (SuperTestEnabled)
                {
                    find += "Паттерн: " + p + "" + Environment.NewLine;
                }
                // замена!
                find += Regex.Replace(text, p, replace, RegexOptions.Multiline | RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.ECMAScript);
                
                if (SuperTestEnabled)
                {
                    find += Environment.NewLine + "----" + Environment.NewLine;
                }
            }
            return find;
        }
    }
}
