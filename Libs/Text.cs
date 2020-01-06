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
            if (!string.IsNullOrEmpty(d))
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
            if (!string.IsNullOrEmpty(d))
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
            if (!string.IsNullOrEmpty(d))
            {
                if (d.IndexOf(Environment.NewLine, System.StringComparison.OrdinalIgnoreCase) > -1)
                {
                    foreach (string s in d.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        r += "[c пробелами: " + s.Length.ToString() + ", без: " + s.Replace(" ", "").Length.ToString() + "] " + s + Environment.NewLine;
                    }
                }
                else
                {
                    r += "[c пробелами: " + d.Length.ToString() + ", без: " + d.Replace(" ", "").Length.ToString() + "] " + d;
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
            if (!string.IsNullOrEmpty(d) && (d.IndexOf(Environment.NewLine, System.StringComparison.OrdinalIgnoreCase) >-1 || d.IndexOf(' ') > -1))
            {
                string[] s = null;
                if (so == SortObject.Strings)
                {
                    s = SuperSort(d.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),type);
                    r = String.Join(Environment.NewLine, s);
                }
                else if (so == SortObject.Words)
                {
                    s = d.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    string[] words = null;
                    string sr = "";
                    if (s != null && s.Length > 0)
                    {
                        foreach (string row in s)
                        {
                            if (row.IndexOf(" ", System.StringComparison.OrdinalIgnoreCase) >-1)
                            {
                                words = SuperSort(row.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries),type);
                                if (!string.IsNullOrEmpty(sr))
                                {
                                    sr += Environment.NewLine;
                                }
                                sr += String.Join(" ",words);
                            } 
                            else
                            {
                                if (!string.IsNullOrEmpty(sr))
                                {
                                    sr += Environment.NewLine;
                                }
                                sr += row;
                            }
                        }
                    }
                    r = sr;
                }
                else if (so == SortObject.Simbols)
                {
                    s = d.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    string[] words = null;
                    string sr = "";
                    if (s != null && s.Length > 0)
                    {
                        foreach (string row in s)
                        {
                            if (row.IndexOf(" ", System.StringComparison.OrdinalIgnoreCase) > -1)
                            {
                                // количество пробелов в строке +1 , дает количество слов
                                string[] nw = new string[row.ToCharArray().Where(i => i == ' ').Count()+1];
                                words = row.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries); //, SuperSort(type);
                                if (words!=null && words.Length>0)
                                {
                                    int i = 0;
                                    foreach (string ws in words)
                                    {
                                        nw[i] = SuperSort(ws.ToCharArray(), type).ToString();
                                        i++;
                                    }
                                }
                                if (!string.IsNullOrEmpty(sr))
                                {
                                    sr += Environment.NewLine;
                                }
                                sr += String.Join(" ", nw);
                            } 
                            else
                            {
                                if (!string.IsNullOrEmpty(sr))
                                {
                                    sr += Environment.NewLine;
                                }
                                sr += row;
                            }
                        }
                    }
                    r = sr;
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
                        Array.Sort(d);
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
        public static string SuperSort(char[] d, SortType type)
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
            return new string(d);
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
                    s = d.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    if (s!=null && s.Length>0)
                    {
                        foreach (string t in s)
                        {
                            if (!string.IsNullOrEmpty(r))
                            {
                                r += Environment.NewLine;
                            }
                            r += (f == TypeAppend.Forward) ? a + t : t + a;
                        }
                    }
                    break;
                case SortObject.Words:
                    s = d.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    if (s != null && s.Length > 0)
                    {
                        foreach (string row in s)
                        {
                            if (!string.IsNullOrEmpty(r))
                            {
                                r += Environment.NewLine;
                            }
                            if (row.IndexOf(" ", StringComparison.OrdinalIgnoreCase) > -1)
                            {
                                string[] words = row.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                                string[] ts = new string[words.Length];
                                int i = 0;
                                foreach (string word in words)
                                {
                                    ts[i] = ((f == TypeAppend.Forward) ? a + word : word + a);
                                    i++;
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
                    s = d.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    if (s != null && s.Length > 0)
                    {
                        foreach (string row in s)
                        {
                            if (!string.IsNullOrEmpty(r))
                            {
                                r += Environment.NewLine;
                            }
                            if (row.IndexOf(" ", System.StringComparison.OrdinalIgnoreCase) > -1)
                            {
                                string[] words = row.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                                string[] ts = new string[words.Length];
                                int i = 0;
                                foreach (string word in words)
                                {
                                    string nw = "";
                                    List<char> chrs = word.ToList<char>();
                                    foreach (char h in chrs)
                                    {
                                        nw += (f == TypeAppend.Forward) ? a + h : h + a;
                                    }
                                    ts[i] = nw;
                                    i++;
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
        /// <summary>
        /// Получить символ из алфавита по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string AlphabetEN(int index)
        {
            string a = "abcdefghijklmnopqrstuvwxyz";
            if (index>=a.Length)
            {
                index = index - a.Length;
            }
            return a[index].ToString();
        }
        /// <summary>
        /// Исправление пунктуации
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string FixPunctuation(string input)
        {
            string r = "";
            // 1. Удаление лишних пробелов
            r = input.Trim().Replace("   ", " ").Replace("  ", " ");
            // 1.1. Точки
            r = r.Replace(" . ", ".");
            // 1.2. Остальные символы
            string p = "~`!@#$%^&*_+(){}[]<>|\\/;:,?№-=≪≫–";
            string n = "";
            foreach (char s in p)
            {
                r = r.Replace(" "+ s.ToString() + " ", s.ToString());
            }
            
            // 2. Установка пробелов в нужных местах
            r = r.Replace(",", ", ").Replace(".", ". ").Replace(". . .", "... ").Replace(". .", ".. ").Replace("  ", " ");
            // 2.1. Кавычки
            r = r.Replace("≪", " ≪").Replace("≫", "≫ ");
            // 2.2. Двоеточие и точка с запятой
            r = r.Replace(":", ": ").Replace(";", "; ");
            // 2.3. Знаки
            r = r.Replace(" !", "!").Replace("!", "! ").Replace("?", "? ").Replace("! ? ", "!? ");
            // 2.4. Длинная тирешка
            r = r.Replace("–", " – ");
            // 2.5. Скобки
            r = r.Replace("(", " (").Replace(")", ") ").Replace("{", " {").Replace("}", "} ").Replace("[", " [").Replace("]", "] ").Replace("<", " <").Replace(">", "> ");
            // 3. Завершающее удаление двойных пробелов
            r = r.Replace("  ", " ");
            return r.Trim(' ');
        }

        public static string[] FindDublicate(string[] input)
        {
            string[] d = new string[input.Length];
            string[] u = new string[input.Length];
            int i = 0,j=0;
            foreach (string s in input)
            {
                // u - уникальные строки
                if (!u.Contains(s))
                {
                    u[i++] = s;
                }
                // d - дубли
                else
                {
                    d[j++] = s;
                }
            }
            return d;
        }

        public static string[] FindDublicateAndReplace(string[] input, string replace)
        {
            string[] r = new string[input.Length];
            string[] u = new string[input.Length];
            int i = 0;
            foreach (string s in input)
            {
                // u - уникальные строки
                if (!u.Contains(s))
                {
                    u[i] = s;
                    r[i] = s;
                }
                // d - дубли
                else
                {
                    r[i] = s.Replace(s, replace);
                }
                i++;
            }
            return r;
        }
    }
}
