using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SuperGeroy.Libs
{
    class Files
    {
        public static string ReplaceNameByMask(string mask, string fileName, int npp)
        {
            if (!String.IsNullOrEmpty(mask) && !String.IsNullOrEmpty(fileName))
            {
                if (mask.IndexOf("<") > -1)
                {

                    List<string> gr = RegExpression.GetStringBetweenTwoStrings(mask, "<", ">");
                    if (gr.Count > 0)
                    {
                        foreach (string r in gr)
                        {
                            if (r.IndexOf('+') > -1)
                            {
                                string pfn = "";
                                string[] rs = r.Replace("<","").Replace(">", "").Split('+');
                                int start = 0, step = 1;
                                string simbol="";
                                // число
                                if (rs[0].IndexOf("?") > -1)
                                {
                                    string n = rs[0].Replace("?", "");
                                    simbol = "?";
                                    try
                                    {
                                        pfn = (int.Parse(n) + (npp * int.Parse(rs[1]))).ToString();
                                    }
                                    catch{}
                                }
                                // буква
                                else if (rs[0].IndexOf("\"") > -1)
                                {
                                    string n = rs[0].Replace("\"", "");
                                    simbol = "\"";
                                    try
                                    {
                                        pfn = Text.AlphabetEN(int.Parse(n) + (npp * int.Parse(rs[1])));
                                    }
                                    catch{}
                                }
                                // меняем маску: <?1+2> на 3
                                mask = mask.Replace(r, pfn);
                            }
                        }
                    }
                } 
                // передать в маску тоже расширение что и было изначательно в файле
                if (mask.EndsWith(".*") || mask.EndsWith(".**") || mask.EndsWith(".***") || mask.EndsWith(".****"))
                {
                    string ext = Path.GetExtension(fileName).Replace(".","");
                    string[] m = mask.Split(new string[] { ".*" },StringSplitOptions.RemoveEmptyEntries);
                    mask = m[0] +"."+ ext;
                }
                // формирование нового имени файла
                fileName = Path.Combine(Path.GetFullPath(fileName).Replace(Path.GetFileName(fileName), "").Trim(), mask);
            }
            return fileName;
        }
    }
}
