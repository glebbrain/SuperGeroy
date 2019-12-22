using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGeroy.Libs
{
    class Text
    {
        public static string ChangeSimbols(string d, Dictionary<string, string> t)
        {
            StringBuilder r = new StringBuilder();
            if (d != "")
            {
                for (int i = 0; i < d.Length; i++)
                {
                    if (t.ContainsKey(d[i].ToString()))
                    {
                        r.Append(t[d[i].ToString()]);
                    }
                    else
                    {
                        r.Append(d[i].ToString());
                    }
                }
                return r.ToString();
            }
            return r.ToString();
        }
        public static string TranslitRuEn(string d)
        {
            Dictionary<string,string> t = new Dictionary<string, string>();
            
            t.Add("а", "a");
            t.Add("б", "b");
            t.Add("в", "v");
            t.Add("г", "g");
            t.Add("д", "d");
            t.Add("е", "ye");
            t.Add("ё", "yo");
            t.Add("ж", "zh");
            t.Add("з", "z");
            t.Add("и", "i");
            t.Add("й", "y");
            t.Add("к", "k");
            t.Add("л", "l");
            t.Add("м", "m");
            t.Add("н", "n");
            t.Add("о", "o");
            t.Add("п", "p");
            t.Add("р", "r");
            t.Add("с", "s");
            t.Add("т", "t");
            t.Add("у", "u");
            t.Add("ф", "f");
            t.Add("х", "kh");
            t.Add("ц", "ts");
            t.Add("ч", "ch");
            t.Add("ш", "sh");
            t.Add("щ", "shch");
            t.Add("ъ", "\"");
            t.Add("ы", "y");
            t.Add("ь", "'");
            t.Add("э", "e");
            t.Add("ю", "yu");
            t.Add("я", "ya");

            t.Add("А", "A");
            t.Add("Б", "B");
            t.Add("В", "V");
            t.Add("Г", "G");
            t.Add("Д", "D");
            t.Add("Е", "YE");
            t.Add("Ё", "YO");
            t.Add("Ж", "ZH");
            t.Add("З", "Z");
            t.Add("И", "I");
            t.Add("Й", "Y");
            t.Add("К", "K");
            t.Add("Л", "L");
            t.Add("М", "M");
            t.Add("Н", "N");
            t.Add("О", "O");
            t.Add("П", "P");
            t.Add("Р", "R");
            t.Add("С", "S");
            t.Add("Т", "T");
            t.Add("У", "U");
            t.Add("Ф", "F");
            t.Add("Х", "KH");
            t.Add("Ц", "TS");
            t.Add("Ч", "CH");
            t.Add("Ш", "SH");
            t.Add("Щ", "SHCH");
            t.Add("Ъ", "\"");
            t.Add("Ы", "Y");
            t.Add("Ь", "'");
            t.Add("Э", "E");
            t.Add("Ю", "YU");
            t.Add("Я", "YA");

           return ChangeSimbols(d,t);
        }

        public static string CapitalizedFirstSimbol(string d, bool WithoutPreText=false)
        {
            string r = "";
            List<string> lstPreText = new List<string>();
            if (WithoutPreText)
            {
                lstPreText.Add("а");
                lstPreText.Add("в");
                lstPreText.Add("и");
                lstPreText.Add("о");
                lstPreText.Add("к");
                lstPreText.Add("с");
                lstPreText.Add("у");
                lstPreText.Add("до");
                lstPreText.Add("за");
                lstPreText.Add("из");
                lstPreText.Add("от");
                lstPreText.Add("об");
                lstPreText.Add("на");
                lstPreText.Add("не");
                lstPreText.Add("но");
                lstPreText.Add("по");
                lstPreText.Add("без");
                lstPreText.Add("над");
                lstPreText.Add("под");
                lstPreText.Add("про");
                lstPreText.Add("для");
                lstPreText.Add("при");
                lstPreText.Add("вне");
                lstPreText.Add("через");
                lstPreText.Add("перед");
                lstPreText.Add("около");
            }
            if (d != "")
            {
                string[] ws = d.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (ws!=null && ws.Length>0)
                {
                    foreach (string w in ws)
                    {
                        string wu = "";
                        if (WithoutPreText && lstPreText.Contains(w.ToLower()))
                        {
                            wu = w;
                        } 
                        else
                        {
                            wu = w[0].ToString().ToUpper() + w.Substring(1, w.Length - 1);
                        }
                        r += wu + " ";
                    }
                }
            }
            return r;
        }

        public static string CalcCountSimbols(string d)
        {
            string r = "";
            if (d != "" && d.IndexOf("\r\n") > -1)
            {
                foreach (string s in d.Split(new string[] { "\r\n" },StringSplitOptions.RemoveEmptyEntries))
                {
                    r += "[c пробелами: " + s.Length.ToString() + ", без: " + s.Replace(" ", "").Length.ToString() + "] " + s;
                }
            }
            return r;
        }
        public static string Reverse(string d)
        {
            char[] c = d.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }

        public static string LayoutChange(string d,bool EnToRU=true)
        {
            Dictionary<string, string> t = new Dictionary<string, string>();
            t.Add("q", "й");
            t.Add("w", "ц");
            t.Add("e", "у");
            t.Add("r", "к");
            t.Add("t", "е");
            t.Add("y", "н");
            t.Add("u", "г");
            t.Add("i", "ш");
            t.Add("o", "щ");
            t.Add("p", "з");
            t.Add("[", "х");
            t.Add("]", "ъ");
            t.Add("a", "ф");
            t.Add("s", "ы");
            t.Add("d", "в");
            t.Add("f", "а");
            t.Add("g", "п");
            t.Add("h", "р");
            t.Add("j", "о");
            t.Add("k", "л");
            t.Add("l", "д");
            t.Add(";", "ж");
            t.Add("'", "э");
            t.Add("z", "я");
            t.Add("x", "ч");
            t.Add("c", "с");
            t.Add("v", "м");
            t.Add("b", "и");
            t.Add("n", "т");
            t.Add("m", "ь");
            t.Add(",", "б");
            t.Add(".", "ю");
            t.Add("`", "ё");

            t.Add("Q", "Й");
            t.Add("W", "Ц");
            t.Add("E", "У");
            t.Add("R", "К");
            t.Add("T", "Е");
            t.Add("Y", "Н");
            t.Add("U", "Г");
            t.Add("I", "Ш");
            t.Add("O", "Щ");
            t.Add("P", "З");
            t.Add("{", "Х");
            t.Add("}", "Ъ");
            t.Add("A", "Ф");
            t.Add("S", "Ы");
            t.Add("D", "В");
            t.Add("F", "А");
            t.Add("G", "П");
            t.Add("H", "Р");
            t.Add("J", "О");
            t.Add("K", "Л");
            t.Add("L", "Д");
            t.Add(":", "Ж");
            t.Add("\"", "Э");
            t.Add("Z", "Я");
            t.Add("X", "Ч");
            t.Add("C", "С");
            t.Add("V", "М");
            t.Add("B", "И");
            t.Add("N", "Т");
            t.Add("M", "Ь");
            t.Add("<", "Б");
            t.Add(">", "Ю");
            t.Add("~", "Ё");

            // русский в английский
            if (EnToRU==false)
            {
                var n = t.ToDictionary(x => x.Value, x => x.Key);
                return ChangeSimbols(d, n);
            }
            // английский в русский
            return ChangeSimbols(d, t);
        }
        public enum SortType
        {
            Sort=0,
            Reverse=1,
            Random=2
        }
        public enum SortObject
        {
            Strings = 0,
            Words = 1,
            Simbols = 2
        }
        public static string SortStrings(string d, SortObject so, SortType type)
        {
            string r = d;
            if (d!="" && d.IndexOf("\r\n")>-1)
            {
                string[] s = null;
                if (so == SortObject.Strings)
                {
                    s = SuperSort(d.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries),type);
                    r = String.Join("\r\n", s);
                }
                else if (so == SortObject.Words)
                {
                    s = d.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] words = null;
                    string sr = "";
                    if (s != null && s.Length > 0)
                    {
                        foreach (string row in s)
                        {
                            if (row.IndexOf(" ")>-1)
                            {
                                words = SuperSort(row.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries),type);
                                if (sr!="")
                                {
                                    sr += "\r\n";
                                }
                                sr += String.Join(" ",words);
                            } 
                            else
                            {
                                if (sr != "")
                                {
                                    sr += "\r\n";
                                }
                                sr += row;
                            }
                        }
                    }
                }
                else if (so == SortObject.Simbols)
                {
                    s = d.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] words = null;
                    string sr = "";
                    if (s != null && s.Length > 0)
                    {
                        foreach (string row in s)
                        {
                            if (row.IndexOf(" ") > -1)
                            {
                                string[] nw = null;
                                words = SuperSort(row.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries), type);
                                if (words!=null && words.Length>0)
                                {
                                    foreach (string ws in words)
                                    {
                                        nw.Append(SuperSort(ws.ToCharArray(), type).ToString());
                                    }
                                }
                                if (sr != "")
                                {
                                    sr += "\r\n";
                                }
                                sr += String.Join(" ", nw);
                            } 
                            else
                            {
                                if (sr != "")
                                {
                                    sr += "\r\n";
                                }
                                sr += row;
                            }
                        }
                    }
                }
            }
            return r;
        }
        /// <summary>
        /// Sort strings, words by sort type
        /// </summary>
        /// <param name="d"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string[] SuperSort(string[] d, SortType type)
        {
            if (d != null && d.Length > 0)
            {
                switch (type)
                {
                    case SortType.Sort:
                        Array.Sort(d);
                        break;
                    case SortType.Reverse:
                        Array.Reverse(d);
                        break;
                    case SortType.Random:
                        Random rnd = new Random();
                        d = d.OrderBy(x => rnd.Next()).ToArray();
                        break;
                    default:
                        break;
                }
            }
            return d;
        }
        /// <summary>
        /// Sort simbols by sort type
        /// </summary>
        /// <param name="d"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static char[] SuperSort(char[] d, SortType type)
        {
            if (d != null && d.Length > 0)
            {
                switch (type)
                {
                    case SortType.Sort:
                        Array.Sort(d);
                        break;
                    case SortType.Reverse:
                        Array.Reverse(d);
                        break;
                    case SortType.Random:
                        Random rnd = new Random();
                        d = d.OrderBy(x => rnd.Next()).ToArray();
                        break;
                    default:
                        break;
                }
            }
            return d;
        }

        public enum TypeAppend
        {
            Forward=0,
            Back=1
        }
        public static string AddText(string d, string a, SortObject o, TypeAppend f)
        {
            string r = "";
            string[] s = null;
            switch (o)
            {
                case SortObject.Strings:
                    s = d.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    if (s!=null && s.Length>0)
                    {
                        foreach (string t in s)
                        {
                            if (r!="")
                            {
                                r += "\r\n";
                            }
                            r += (f == TypeAppend.Forward) ? a + t : t + a;
                        }
                    }
                    break;
                case SortObject.Words:
                    s = d.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    if (s != null && s.Length > 0)
                    {
                        foreach (string row in s)
                        {
                            if (r != "")
                            {
                                r += "\r\n";
                            }
                            if (row.IndexOf(" ") > -1)
                            {
                                string[] words = row.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                                string[] ts = null;
                                foreach (string word in words)
                                {
                                    ts.Append((f == TypeAppend.Forward) ? a + word : word + a);
                                }
                                r += String.Join(" ", ts);
                            } 
                            else
                            {
                                r += row;
                            }
                        }
                    }
                    break;
                case SortObject.Simbols:
                    s = d.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    if (s != null && s.Length > 0)
                    {
                        foreach (string row in s)
                        {
                            if (r != "")
                            {
                                r += "\r\n";
                            }
                            if (row.IndexOf(" ") > -1)
                            {
                                string[] words = row.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                                string[] ts = null;
                                foreach (string word in words)
                                {
                                    string nw = "";
                                    List<char> chrs = word.ToList<char>();
                                    foreach (char h in chrs)
                                    {
                                        nw += (f == TypeAppend.Forward) ? a + h : h + a;
                                    }
                                    ts.Append(nw);
                                }
                                r += String.Join(" ", ts);
                            }
                            else
                            {
                                r += row;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            return r;
        }
    }
}
