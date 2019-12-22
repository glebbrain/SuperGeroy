using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGeroy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: в будущем планируется:
            //  1. Strings
            //  2. RegEx
            //   . ...
            // 98. Automation Social Net
            // 99. AI chat room

            // TODO: Сделать тестирование функционала
        }

        #region Интерфейс Form1

        private void superGeroyНаGiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/glebbrain/SuperGeroy");
        }

        private void авторGlebBrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCt5WblLHoLc6ZH3kCKhfbuw?view_as=subscriber");
        }

        private void генераторПаролейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://glebrain.ru/randpass");
        }

        private void настройкаGitВVisualStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://habr.com/ru/sandbox/112936/");
        }
        /// <summary>
        /// Clear and set default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = 0;
        }
        public string SpecSimbolsCB(int index)
        {
            string r = "";
            switch (index)
            {
                case 1:
                    r = Environment.NewLine;
                    break;
                case 2:
                    r = "\t";
                    break;
                case 3:
                    r = "        ";
                    break;
                case 4:
                    r = "    ";
                    break;
                case 5:
                    r = "  ";
                    break;
                default:
                    r = "";
                    break;
            }
            return r;
        }
        public string FindSpecSimbol = "";
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FindSpecSimbol = SpecSimbolsCB(comboBox2.SelectedIndex);
        }
        public string ReplaceSpecSimbol = "";
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ReplaceSpecSimbol = SpecSimbolsCB(comboBox3.SelectedIndex);
        }
        public string patternRegEx = "";
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: если не указана Замена, сразу выводить поиск по регулярке
            // TODO: сделать подгрузку списка регулярок из файла или БД - на будущие
            /*
            0 Регулярное выражение
            1 email@email.com
            */
            button1.Enabled = false;
            switch (comboBox6.SelectedIndex)
            {
                case 1:
                    // email
                    this.patternRegEx = @"[A-Za-z]+[\.A-Za-z0-9_-]*[A-Za-z0-9]+@[A-Za-z]+\.[A-Za-z]+";
                    break;
                case 2:
                    // telephone number USA
                    this.patternRegEx = @"\+(9[976]\d|8[987530]\d|6[987]\d|5[90]\d|42\d|3[875]\d|2[98654321]\d|9[8543210]|8[6421]|6[6543210]|5[87654321]|4[987654310]|3[9643210]|2[70]|7|1)\d{1,14}$";
                    // phone Russia
                    //this.patternRegEx = @"^((\+7|7|8)+([0-9]){10})$";
                    //TODO а здесь надо сделать перебор во всем возможным номерам: http://phoneregex.com/#%5E((%5C%2B7%7C7%7C8)%2B(%5B0-9%5D)%7B10%7D)%24
                    break;
                case 3:
                    // (http|http(s)?://)?([\w-]+\.)+[\w-]+[.com|.in|.org]+(\[\?%&=]*)?
                    // ^(http|https)://.*$
                    this.patternRegEx = @"^(http|https)://.*$";
                    break;
                default:
                    break;
            }
            if (!string.IsNullOrEmpty(this.patternRegEx))
            {
                button1.Enabled = true;
            }            
        }
        private string FindSpecSimbolCB5 = "";
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.FindSpecSimbolCB5 = SpecSimbolsCB(comboBox5.SelectedIndex);
            if (!string.IsNullOrEmpty(this.FindSpecSimbolCB5))
            {
                button1.Enabled = true;
            }
            
        }
        private string ReplaceSpecSimbolCB4 = "";
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.ReplaceSpecSimbolCB4 = SpecSimbolsCB(comboBox4.SelectedIndex);
            if (!string.IsNullOrEmpty(this.ReplaceSpecSimbolCB4))
            {
                button1.Enabled = true;
            }
        }
        #endregion

        #region Текст

        /// <summary>
        /// Выполнить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                // Разбить текст на строки по символу или тексту
                // find: textBox3 and comboBox2
                // replace: textBox4 and comboBox3

                string TextJoin = (textBox4.Text.Trim() != "" ? textBox4.Text : this.ReplaceSpecSimbol);

                if (comboBox1.SelectedIndex == 1)
                {
                    if (textBox3.Text.Length > 0)
                    {
                        if (textBox4.Text.Length > 0)
                        {
                            WriteResult(String.Join(textBox4.Text, textBox1.Text.Split(new string[] { textBox3.Text }, StringSplitOptions.RemoveEmptyEntries)));
                        }
                        else if(comboBox3.Text.Length > 0 && comboBox3.Text != "Спец. символы")
                        {
                            WriteResult(String.Join(this.ReplaceSpecSimbol, textBox1.Text.Split(new string[] { textBox3.Text }, StringSplitOptions.RemoveEmptyEntries)));
                        }
                        
                    }
                    else if (comboBox2.Text.Length > 0 && comboBox2.Text != "Спец. символы")
                    {
                        if (textBox4.Text.Length > 0)
                        {
                            WriteResult(String.Join(textBox4.Text, textBox1.Text.Split(new string[] { this.FindSpecSimbol }, StringSplitOptions.RemoveEmptyEntries)));
                        }
                        else if (comboBox3.Text.Length > 0 && comboBox3.Text != "Спец. символы")
                        {
                            WriteResult(String.Join(this.ReplaceSpecSimbol, textBox1.Text.Split(new string[] { this.FindSpecSimbol }, StringSplitOptions.RemoveEmptyEntries)));
                        }
                       
                    }
                }
                // Добавить текст перед строкой
                else if (comboBox1.SelectedIndex == 26)
                {
                    WriteResult(Libs.Text.AddText(textBox1.Text, TextJoin, Libs.Text.SortObject.Strings, Libs.Text.TypeAppend.Forward));
                }
                // Добавить текст после строки
                else if (comboBox1.SelectedIndex == 27)
                {
                    WriteResult(Libs.Text.AddText(textBox1.Text, TextJoin, Libs.Text.SortObject.Strings, Libs.Text.TypeAppend.Back));
                }
                // Добавить текст перед словом
                else if (comboBox1.SelectedIndex == 28)
                {
                    WriteResult(Libs.Text.AddText(textBox1.Text, TextJoin, Libs.Text.SortObject.Words, Libs.Text.TypeAppend.Forward));
                }
                // Добавить текст после слова
                else if (comboBox1.SelectedIndex == 29)
                {
                    WriteResult(Libs.Text.AddText(textBox1.Text, TextJoin, Libs.Text.SortObject.Words, Libs.Text.TypeAppend.Back));
                }
                // Добавить текст перед буквой
                else if (comboBox1.SelectedIndex == 30)
                {
                    WriteResult(Libs.Text.AddText(textBox1.Text, TextJoin, Libs.Text.SortObject.Simbols, Libs.Text.TypeAppend.Forward));
                }
                // Добавить текст после буквы
                else if (comboBox1.SelectedIndex == 31)
                {
                    WriteResult(Libs.Text.AddText(textBox1.Text, TextJoin, Libs.Text.SortObject.Simbols, Libs.Text.TypeAppend.Back));
                }
                // Поиск
                else if (textBox6.Text.Length > 0 || 
                    (comboBox5.Text.Length > 0 && comboBox5.Text.Trim() != "Спец. символы" && this.FindSpecSimbolCB5.Length>0) || 
                    (comboBox6.Text.Length > 0 && comboBox6.Text.Trim() != "Регулярное выражение" && this.patternRegEx != null)
                )
                {
                    string find = "";

                    //выводит найдненное по регулярному выражению

                    if (this.patternRegEx != null)
                    {
                        find = "";
                        MatchCollection matches = Regex.Matches(textBox1.Text, this.patternRegEx);
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

                    }
                    else
                    {
                        //выводит строки содержащие искомое
                        string textFind = textBox6.Text.Length > 0 ? textBox6.Text : this.FindSpecSimbolCB5;
                        if (textBox1.Text.IndexOf(textFind, System.StringComparison.OrdinalIgnoreCase) > -1)
                        {
                            if (textBox1.Text.IndexOf(Environment.NewLine, System.StringComparison.OrdinalIgnoreCase) > -1)
                            {
                                foreach (var row in textBox1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                                {
                                    if (row.IndexOf(textFind, System.StringComparison.OrdinalIgnoreCase) > -1)
                                    {
                                        if (!String.IsNullOrEmpty(find))
                                        {
                                            find += Environment.NewLine;
                                        }
                                        find += row;
                                    }
                                }
                            }
                        }
                    }
                    // выводим найденное
                    WriteResult(find);

                    // Замена
                    if (textBox5.Text.Length>0 || 
                        (comboBox4.Text.Length>0 && comboBox4.Text.Trim() != "Спец. символы" && this.ReplaceSpecSimbolCB4.Length > 0)
                    )
                    {
                        string rplc = (textBox5.Text.Length > 0 ? textBox5.Text : this.ReplaceSpecSimbolCB4);
                        // или выводим замененное
                        WriteResult(textBox1.Text.Replace(find, rplc));
                    }
                }
            }
        }
        
        #endregion

        #region Helpers
        public void WriteResult(string d="")
        {
            // Изменение пишутся в исходник
            if (checkBox1.Checked)
            {
                textBox1.Text = d;
            }
            // Изменения записываются во второе окно
            else
            {
                textBox2.Text = d;
            }
        }


        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            
             0  Действие
           + 1  Разбить текст на строки по символу или тексту
           + 2  Транслит
           + 3  Все слова с Заглавной буквы
           + 4  Все слова с Заглавной буквы без предлогов
             5  ----------------------------------------
           + 6  Все прописью
           + 7  Все Заглавной
             8  ----------------------------------------
           + 9  Убрать лишние пробелы
           + 10 Количество символов в начало строки
           + 11 Перевернуть строку
             12 ----------------------------------------
           + 13 Сменить раскладку QWERTY с RU на EN
           + 14 Сменить раскладку QWERTY с EN на RU
             15 ----------------------------------------
           + 16 Сортировка строк от А до Я
           + 17 Сортировка строк от Я до А
           + 18 Случайная перестановка строк
           + 19 Сортировка слов в строке от А до Я
           + 20 Сортировка слов в строке от Я до А
           + 21 Случайная перестановка слов
           + 22 Сортировка букв в слове от А до Я
           + 23 Сортировка букв в слове от Я до А
           + 24 Случайная перестановка букв
             25 ----------------------------------------
           + 26 Добавить текст перед строкой
           + 27 Добавить текст после строки
           + 28 Добавить текст перед словом
           + 29 Добавить текст после слова
           + 30 Добавить текст перед буквой
           + 31 Добавить текст после буквы
             32 ----------------------------------------
            
            
            */

            textBox3.Enabled = false;
            comboBox2.Enabled = false;
            textBox4.Enabled = false;
            comboBox3.Enabled = false;
            comboBox3.SelectedIndex = 0;
            button1.Enabled = false;

            // Split and Join
            if (comboBox1.SelectedIndex == 1)
            {
                textBox3.Enabled = true;
                comboBox2.Enabled = true;
                textBox4.Enabled = true;
                comboBox3.Enabled = true;
                comboBox3.SelectedIndex = 1;
                button1.Enabled = true;
            }
            // Transliteration
            else if (comboBox1.SelectedIndex == 2)
            {
                WriteResult(Libs.Text.TranslitRuEn(textBox1.Text));
            }
            // Capitalized first simbol on word
            else if (comboBox1.SelectedIndex == 3)
            {
                WriteResult(Libs.Text.CapitalizedFirstSimbol(textBox1.Text));
            }
            // Capitalized first simbol on word without pretext
            else if (comboBox1.SelectedIndex == 4)
            {
                WriteResult(Libs.Text.CapitalizedFirstSimbol(textBox1.Text,true));
            }
            // Все прописью
            else if (comboBox1.SelectedIndex == 6)
            {
                WriteResult(textBox1.Text.ToLowerInvariant());
            }
            // Все Заглавной
            else if (comboBox1.SelectedIndex == 7)
            {
                WriteResult(textBox1.Text.ToLowerInvariant());
            }
            // Убрать лишние пробелы
            else if (comboBox1.SelectedIndex == 9)
            {
                WriteResult(textBox1.Text.Replace("   "," ").Replace("  "," ").ToString().Trim());
            }
            // Количество символов в начало строки
            else if (comboBox1.SelectedIndex == 10)
            {
                WriteResult(Libs.Text.CalcCountSimbols(textBox1.Text));
            }
            // Перевернуть строку Reverse
            else if (comboBox1.SelectedIndex == 11)
            {
                WriteResult(Libs.Text.Reverse(textBox1.Text));
            }
            // Сменить раскладку QWERTY с RU на EN
            else if (comboBox1.SelectedIndex == 13)
            {
                WriteResult(Libs.Text.LayoutChange(textBox1.Text, false));
            }
            // Сменить раскладку QWERTY с EN на RU
            else if (comboBox1.SelectedIndex == 14)
            {
                WriteResult(Libs.Text.LayoutChange(textBox1.Text));
            }
            // Сортировка строк от А до Я
            else if (comboBox1.SelectedIndex == 16)
            {
                WriteResult(Libs.Text.SortStrings(textBox1.Text, Libs.Text.SortObject.Strings, Libs.Text.SortType.Sort));
            }
            // Сортировка строк от Я до А
            else if (comboBox1.SelectedIndex == 17)
            {
                WriteResult(Libs.Text.SortStrings(textBox1.Text, Libs.Text.SortObject.Strings, Libs.Text.SortType.Reverse));
            }
            // + Случайная перестановка строк
            else if (comboBox1.SelectedIndex == 18)
            {
                WriteResult(Libs.Text.SortStrings(textBox1.Text, Libs.Text.SortObject.Strings, Libs.Text.SortType.Random));
            }
            // Сортировка слов в строке от А до Я
            else if (comboBox1.SelectedIndex == 19)
            {
                WriteResult(Libs.Text.SortStrings(textBox1.Text, Libs.Text.SortObject.Words, Libs.Text.SortType.Sort));
            }
            // Сортировка слов в строке от Я до А
            else if (comboBox1.SelectedIndex == 20)
            {
                WriteResult(Libs.Text.SortStrings(textBox1.Text, Libs.Text.SortObject.Words, Libs.Text.SortType.Reverse));
            }
            // Случайная перестановка слов
            else if (comboBox1.SelectedIndex == 21)
            {
                WriteResult(Libs.Text.SortStrings(textBox1.Text, Libs.Text.SortObject.Words, Libs.Text.SortType.Random));
            }
            // Сортировка букв в слове от А до Я
            else if (comboBox1.SelectedIndex == 22)
            {
                WriteResult(Libs.Text.SortStrings(textBox1.Text, Libs.Text.SortObject.Simbols, Libs.Text.SortType.Sort));
            }
            // Сортировка букв в слове от Я до А
            else if (comboBox1.SelectedIndex == 23)
            {
                WriteResult(Libs.Text.SortStrings(textBox1.Text, Libs.Text.SortObject.Simbols, Libs.Text.SortType.Reverse));
            }
            // Случайная перестановка букв
            else if (comboBox1.SelectedIndex == 24)
            {
                WriteResult(Libs.Text.SortStrings(textBox1.Text, Libs.Text.SortObject.Simbols, Libs.Text.SortType.Random));
            }
            // Добавить текст в начало/конец строки,слова,символа
            else if (comboBox1.SelectedIndex >= 26 && comboBox1.SelectedIndex <= 31)
            {
                textBox4.Enabled = true;
                comboBox3.Enabled = true;
                button1.Enabled = true;
            }
        }

        
    }
}
