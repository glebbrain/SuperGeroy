using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            // TODO:
            //  1. Strings
            //  2. RegEx
            //   . ...
            // 98. Automation Social Net
            // 99. AI chat room
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
                    if (textBox3.Text!="")
                    {
                        if (textBox4.Text!="")
                        {
                            WriteResult(String.Join(textBox4.Text, textBox1.Text.Split(new string[] { textBox3.Text }, StringSplitOptions.RemoveEmptyEntries)));
                        }
                        else if(comboBox3.Text != "" && comboBox3.Text != "Спец. символы")
                        {
                            WriteResult(String.Join(this.ReplaceSpecSimbol, textBox1.Text.Split(new string[] { textBox3.Text }, StringSplitOptions.RemoveEmptyEntries)));
                        }
                        
                    }
                    else if (comboBox2.Text != "" && comboBox2.Text != "Спец. символы")
                    {
                        if (textBox4.Text != "")
                        {
                            WriteResult(String.Join(textBox4.Text, textBox1.Text.Split(new string[] { this.FindSpecSimbol }, StringSplitOptions.RemoveEmptyEntries)));
                        }
                        else if (comboBox3.Text != "" && comboBox3.Text != "Спец. символы")
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
