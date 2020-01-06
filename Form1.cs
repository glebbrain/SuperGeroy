using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
        private void ночнойСтильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ночнойСтильToolStripMenuItem.Checked)
            {
                // фон
                this.BackColor = Color.FromArgb(36, 36, 36);
                textBox1.BackColor = Color.FromArgb(36, 36, 36);
                textBox2.BackColor = Color.FromArgb(36, 36, 36);
                tabPage1.BackColor = Color.FromArgb(36, 36, 36);
                tabPage2.BackColor = Color.FromArgb(36, 36, 36);

                // текст
                this.ForeColor = Color.FromArgb(78, 164, 65);
                textBox1.ForeColor = Color.FromArgb(78, 164, 65);
            } 
            else
            {
                // фон
                this.BackColor = Color.FromKnownColor(KnownColor.Control);
                textBox1.BackColor = Color.FromKnownColor(KnownColor.Window);
                textBox2.BackColor = Color.FromKnownColor(KnownColor.Window);
                tabPage1.BackColor = Color.FromKnownColor(KnownColor.Transparent);
                tabPage2.BackColor = Color.FromKnownColor(KnownColor.Transparent);

                // текст
                this.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                textBox1.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }

        }
        private void стандартныйРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            стандартныйРежимToolStripMenuItem.Checked = true;
            SuperTestEnabled.Checked = false;
            this.Text = "SuperGeroy";
        }

        private void SuperTestEnabled_Click(object sender, EventArgs e)
        {
            стандартныйРежимToolStripMenuItem.Checked = false;
            SuperTestEnabled.Checked = true;
            this.Text = "SuperGeroy [Тестовый режим]";
        }
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
        private static string SpecSimbolsCB(string text)
        {
            string r = "";
            if (text == "Новая строка (Enter)")
            {
                r = Environment.NewLine;
            }
            else if (text== "Табуляция")
            {
                r = "\t";
            }
            else if (text== "8 пробелов")
            {
                r = "        ";
            }
            else if (text== "4 пробела")
            {
                r = "    ";
            }
            else if (text== "2 пробела")
            {
                r = "  ";
            }
            else if (text== "1 пробел")
            {
                r = " ";
            }
            else if (text == "Все символы")
            {
                r = "~`!@#$%^&*(){}<>_-+=?.№;:|\"},/'";
            }
            else if (text == "Спец. символы")
            {
                r = "";
            }
            else if (text== "Пустота")
            {
                r = "";
            }
            else if (text== "Дубликаты строк")
            {
                r = "{dublicat_strings}";
            }
            else if (text == "Дубликаты слов")
            {
                r = "{dublicat_words}";
            }
            return r;
        }
        private string FindSpecSimbol = "";
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
            this.FindSpecSimbol = SpecSimbolsCB(comboBox2.Text);
            comboBox2.SelectionLength = 0;
        }
        private string ReplaceSpecSimbol = "";
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            this.ReplaceSpecSimbol = SpecSimbolsCB(comboBox3.Text);
            comboBox3.SelectionLength = 0;
        }
        private string patternRegEx = "";
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
                    this.patternRegEx = "email";
                    // Включен тестовый режим
                    if (SuperTestEnabled.Checked)
                    {
                        textBox1.Text =
                            "test@testgu.ru"
                            + Environment.NewLine + "te.st@testgu.ru"
                            + Environment.NewLine + "t.es-t@testgu.ru"
                            + Environment.NewLine + "test@tes-tgu.ru"
                            + Environment.NewLine + "test@dev.tes-tgu.ru"
                            + Environment.NewLine + "ta_sd-es.t@dev.tes-tgu.ru"
                            + Environment.NewLine + "----------------------------"
                            + Environment.NewLine + "tasd-est@a.rutasd-est@a.ru"
                            + Environment.NewLine + "сусликихомячутся@a.rutasd-est@a.ru"
                        ;
                    }
                    break;
                case 2:
                    this.patternRegEx = "telephone";
                    // Включен тестовый режим
                    if (SuperTestEnabled.Checked)
                    {
                        textBox1.Text =
                            "многотекста: +7 123 123 12 12 текст в тексте!"
                            + Environment.NewLine + "+7 (123) 123 12 12"
                            + Environment.NewLine + "+7(123) 123-12-12"
                            + Environment.NewLine + "Тест+7 987 654-32-10"
                            + Environment.NewLine + "8 123 123-12-12"
                            + Environment.NewLine + "Тест+7(123) 123 00-00Тест"
                            + Environment.NewLine + "Тест+7(123) 321 0000Тест"
                            + Environment.NewLine + "+7(123) 1231212"
                            + Environment.NewLine + "+7 1231231212"
                            + Environment.NewLine + "+71231231212"
                            + Environment.NewLine + "1231231212"
                            + Environment.NewLine + "81231231212"
                            + Environment.NewLine + "+11231231212"
                            + Environment.NewLine + "+11231231212"
                            + Environment.NewLine + "----------------------------"
                            + Environment.NewLine + "Тетест10100186ТеСт79782434112Тестовый"
                            + Environment.NewLine + "12-12-25"
                        ;
                    }
                    break;
                case 3:
                    this.patternRegEx = "url";
                    // Включен тестовый режим
                    if (SuperTestEnabled.Checked)
                    {
                        textBox1.Text =
                            "ftp://test.ru"
                            + Environment.NewLine + "http://test.ru"
                            + Environment.NewLine + "https://test.ru"
                            + Environment.NewLine + "https://test.ru?a=b"
                            + Environment.NewLine + "https://test.ru&a=b"
                            + Environment.NewLine + "https://test.ru/catalog/product/test"
                            + Environment.NewLine + "https://test.ru/catalog/product/test?price=10&count=1"
                            + Environment.NewLine + "----------------------------"
                            + Environment.NewLine + "ws://test.ru/catalog/product/test?price=10&count=1"
                        ;
                    }
                    break;
                case 4:
                    this.patternRegEx = "ip";
                    // Включен тестовый режим
                    if (SuperTestEnabled.Checked)
                    {
                        textBox1.Text =
                            "0.0.0.0"
                            + Environment.NewLine + "127.0.0.1"
                            + Environment.NewLine + "8.8.8.8"
                            + Environment.NewLine + "255.255.255.255"
                            + Environment.NewLine + "----------------------------"
                            + Environment.NewLine + "798.10.0.12"
                        ;
                    }
                    break;
                default:
                    break;
            }
            if (!string.IsNullOrEmpty(this.patternRegEx))
            {
                button1.Enabled = true;
            }

            comboBox6.SelectionLength = 0;
        }
        private string FindSpecSimbolCB5 = "";
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = "";
            button1.Enabled = false;
            this.FindSpecSimbolCB5 = SpecSimbolsCB(comboBox5.Text);
            if (!string.IsNullOrEmpty(this.FindSpecSimbolCB5))
            {
                button1.Enabled = true;
            }
            comboBox6.Text = "Регулярное выражение";
            comboBox5.SelectionLength = 0;
        }
        private string ReplaceSpecSimbolCB4 = "";
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
            button1.Enabled = false;
            this.ReplaceSpecSimbolCB4 = SpecSimbolsCB(comboBox4.Text);
            if (comboBox4.Text!= "Спец. символы")
            {
                button1.Enabled = true;
            }
            comboBox4.SelectionLength = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                  0.  Действие
                + 1.  Разбить текст на строки по символу или тексту
                + 2.  Транслит
                + 3.  Все слова с Заглавной буквы
                + 4.  Все слова с Заглавной буквы без предлогов
                  5.  ----------------------------------------
                + 6.  Все прописью
                + 7.  Все Заглавной
                  8.  ----------------------------------------
                + 9.  Убрать лишние пробелы
                + 10. Количество символов в начало строки
                + 11. Перевернуть строку
                  12. ----------------------------------------
                + 13. Сменить раскладку QWERTY с RU на EN
                + 14. Сменить раскладку QWERTY с EN на RU
                  15. ----------------------------------------
                + 16. Сортировка строк от А до Я
                + 17. Сортировка строк от Я до А
                + 18. Случайная перестановка строк
                + 19. Сортировка слов в строке от А до Я
                + 20. Сортировка слов в строке от Я до А
                + 21. Случайная перестановка слов
                + 22. Сортировка букв в слове от А до Я
                + 23. Сортировка букв в слове от Я до А
                + 24. Случайная перестановка букв
                  25. ----------------------------------------
                + 26. Добавить текст перед строкой
                + 27. Добавить текст после строки
                + 28. Добавить текст перед словом
                + 29. Добавить текст после слова
                + 30. Добавить текст перед буквой
                + 31. Добавить текст после буквы
                  32. ----------------------------------------
                + 33. Исправление пунктуации
            */

            textBox3.Enabled = false;
            comboBox2.Enabled = false;
            textBox4.Enabled = false;
            comboBox3.Enabled = false;
            comboBox3.SelectedIndex = 0;
            button1.Enabled = true;
            button5.Enabled = true; // repeat action

            // Split and Join
            if (comboBox1.SelectedIndex == 1)
            {
                textBox3.Enabled = true;
                comboBox2.Enabled = true;
                textBox4.Enabled = true;
                comboBox3.Enabled = true;
                // разбитие по умолчанию - Enter
                comboBox3.SelectedIndex = 1;
                this.ReplaceSpecSimbol = "\r\n";
                button5.Enabled = false;
            }
            // Transliteration
            else if (comboBox1.SelectedIndex == 2)
            {
                WriteResult(Libs.Text.TranslitRuEn(textBox1.Text));
            }
            // Capitalized first simbol on word
            else if (comboBox1.SelectedIndex == 3)
            {
                WriteResult(Libs.Text.CapitalizedFirstSimbol(textBox1.Text.ToLower()));
            }
            // Capitalized first simbol on word without pretext
            else if (comboBox1.SelectedIndex == 4)
            {
                WriteResult(Libs.Text.CapitalizedFirstSimbol(textBox1.Text.ToLower(), true));
            }
            // Все прописью
            else if (comboBox1.SelectedIndex == 6)
            {
                WriteResult(textBox1.Text.ToLowerInvariant());
            }
            // Все Заглавной
            else if (comboBox1.SelectedIndex == 7)
            {
                WriteResult(textBox1.Text.ToUpperInvariant());
            }
            // Убрать лишние пробелы
            else if (comboBox1.SelectedIndex == 9)
            {
                WriteResult(textBox1.Text.Replace("   ", " ").Replace("  ", " ").ToString().Trim());
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
            //
            else if (comboBox1.SelectedIndex >= 26 && comboBox1.SelectedIndex <= 31)
            {
                textBox4.Enabled = true;
                comboBox3.Enabled = true;
                button1.Enabled = true;
                button5.Enabled = false;
            }
            // Исправление пунктуации
            else if (comboBox1.SelectedIndex==33)
            {
                // изменения пишутся в исходник
                if (checkBox1.Checked) 
                {
                    WriteResult(Libs.Text.FixPunctuation(textBox1.Text));
                    Thread.Sleep(100);
                    WriteResult(Libs.Text.FixPunctuation(textBox1.Text));
                }
                else
                {
                    WriteResult(Libs.Text.FixPunctuation(textBox1.Text));
                    Thread.Sleep(100);
                    WriteResult(Libs.Text.FixPunctuation(textBox2.Text));
                }
            }
            comboBox1.SelectionLength = 0;
        }
        private void comboBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Выполнить
                button1.PerformClick();
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "Спец. символы";
        }

        private void textBox3_TextClick(object sender, EventArgs e)
        {
            comboBox2.Text = "Спец. символы";
        }
        private void textBox6_TextClick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            comboBox5.Text = "Спец. символы";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            comboBox4.Text = "Спец. символы";
        }
        #endregion

        #region кнопка Выполнить
        public delegate void AsyncAction();
        public delegate void DispatcherInvoker(Form form, AsyncAction a);
        public class Dispatcher
        {
            public static void Invoke(Form form, AsyncAction action)
            {
                if (!form.InvokeRequired)
                {
                    action();
                }
                else
                {
                    form.Invoke((DispatcherInvoker)Invoke, form, action);
                }
            }
        }
        /// <summary>
        /// Выполнить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Текст
            if (tabControl1.SelectedIndex==0) // Текст
            {
                if (textBox1.Text != "")
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
                            else if (comboBox3.Text.Length > 0 && comboBox3.Text != "Спец. символы")
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
                    /*
                          25. ----------------------------------------
                        + 26. Добавить текст перед строкой
                        + 27. Добавить текст после строки
                        + 28. Добавить текст перед словом
                        + 29. Добавить текст после слова
                        + 30. Добавить текст перед буквой
                        + 31. Добавить текст после буквы
                          32. ----------------------------------------
                    */
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
                        (comboBox5.Text.Length > 0 && comboBox5.Text.Trim() != "Спец. символы" && this.FindSpecSimbolCB5.Length > 0) ||
                        (comboBox6.Text.Length > 0 && comboBox6.Text.Trim() != "Регулярное выражение" && this.patternRegEx != null)
                    )
                    {
                        string find = "";

                        // Замена
                        if (textBox5.Text.Length > 0 ||
                            (comboBox4.Text.Length > 0 && comboBox4.Text.Trim() != "Спец. символы")
                        )
                        {
                            string textFind = textBox6.Text.Length > 0 ? textBox6.Text : this.FindSpecSimbolCB5;
                            string textRepl = textBox5.Text.Length > 0 ? textBox5.Text : this.ReplaceSpecSimbolCB4;
                            // Дубликаты строк
                            if (this.FindSpecSimbolCB5 == "{dublicat_strings}")
                            {
                                if (this.ReplaceSpecSimbolCB4 == "")
                                {
                                    // удаляем дубликаты через Distinct
                                    WriteResult(String.Join(Environment.NewLine, textBox1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Where(s => s != "").Distinct().ToArray()));
                                } 
                                else
                                {
                                    // ищем дубликаты и не изменяя структуры массива помечаим дубли, а затем заменяем их
                                    WriteResult(String.Join(Environment.NewLine, Libs.Text.FindDublicateAndReplace(textBox1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries), this.ReplaceSpecSimbolCB4)));
                                }
                                
                            }
                            // Дубликаты слов
                            else if (this.FindSpecSimbolCB5 == "{dublicat_words}" && this.ReplaceSpecSimbolCB4 == "")
                            {
                                if (this.ReplaceSpecSimbolCB4 == "")
                                {
                                    // бьём по пробелам, потом через Distinct удаляем дубли и обратно соединяем по пробелам
                                    WriteResult(String.Join(" ", textBox1.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Where(s => s != "").Distinct().ToArray()));
                                }
                                else
                                {
                                    // ищем дубликаты и не изменяя структуры массива помечаим дубли, а затем заменяем их
                                    WriteResult(String.Join( " ", Libs.Text.FindDublicateAndReplace(textBox1.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries), this.ReplaceSpecSimbolCB4)));
                                }
                            }
                            // поиск всех: ~`!@#$%^&*(){}<>_-+=?.№;:|"},/'
                            else if (comboBox5.Text == "Все символы")
                            {
                                //TODO: Перенести в Libs.Text
                                string res = textBox1.Text;
                                foreach (char s in this.FindSpecSimbolCB5.ToArray())
                                {
                                    res = res.Replace(s.ToString(), textRepl);
                                }
                                WriteResult(res);
                            }
                            // Поиск и замена по регулярным выражениям
                            else if (this.patternRegEx != null)
                            {
                                WriteResult(Libs.RegExpression.ReplaceStandartPattern(textBox1.Text, this.patternRegEx, this.ReplaceSpecSimbolCB4, SuperTestEnabled.Checked));
                            }
                            else
                            {
                                WriteResult(textBox1.Text.Replace(textFind, textRepl));
                            }
                        } 
                        /// Поиск
                        else 
                        {
                            if (this.FindSpecSimbolCB5 == "{dublicat_strings}" && this.ReplaceSpecSimbolCB4 == "")
                            {
                                // выводим дубликаты
                                WriteResult(String.Join(Environment.NewLine, Libs.Text.FindDublicate(find.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))));
                            }
                            // Дубликаты слов
                            else if (this.FindSpecSimbolCB5 == "{dublicat_words}" && this.ReplaceSpecSimbolCB4 == "")
                            {
                                // выводим дубликаты
                                WriteResult(String.Join(" ", Libs.Text.FindDublicate(find.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries))));
                            }
                            // Поиск по регулярным выражениям
                            else if (this.patternRegEx != null)
                            {
                                WriteResult(Libs.RegExpression.FindStandartPattern(textBox1.Text,this.patternRegEx,SuperTestEnabled.Checked));
                            }
                            else
                            {
                                //TODO: Перенести в Libs.Text
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
                                WriteResult(find);
                            }
                        }
                    }
                }
            }
            // Файлы
            else if (tabControl1.SelectedIndex == 1) 
            {
                // путь к директории с файлами:
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(comboBox7.Text))
                {
                    if (Directory.Exists(textBox1.Text))
                    {
                        string newfile = "", msg="";
                        int i = 0, cntfiles = Directory.GetFiles(textBox1.Text).Length;
                        toolStripProgressBar1.Maximum = cntfiles;
                        foreach (var file in Directory.GetFiles(textBox1.Text))
                        {
                            // асинхронный вызов, для отображения данных на форме
                            Dispatcher.Invoke(this, () =>
                            {
                                newfile = Libs.Files.ReplaceNameByMask(comboBox7.Text, file, i);
                                try
                                {
                                    File.Move(file, newfile);
                                    msg = "'" + file + "' => '" + newfile + "'";
                                }
                                catch (Exception ex) 
                                {
                                    msg = "При переименовании из '" + file + "' в '"+ newfile + "' возникла ошибка: '" + ex.Message + "'";
                                }
                                textBox2.Text += msg;
                                // прокручивание на последнюю строку
                                textBox2.SelectionStart = textBox2.Text.Length;
                                textBox2.ScrollToCaret();
                                // обработанные файлы
                                toolStripStatusLabel1.Text = (i+1)+ " / "+ cntfiles;
                                // отображение прогресса
                                toolStripProgressBar1.Value += 1; 

                            });

                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Указанной '" + textBox1.Text + "' директории не существует!") == DialogResult.OK)
                        {
                            textBox1.Focus();
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("В левом верхнем текстовом поле должен быть указан каталог!") == DialogResult.OK)
                    {
                        textBox1.Focus();
                    }
                } 
            }
        }
        /// <summary>
        /// Результат из textbox2.Text в textbox1.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            textBox2.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = s;
        }
        /// <summary>
        /// Добавление результата к исходному тексту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += Environment.NewLine + textBox2.Text;
            textBox2.Text = "";
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

        
    }
}
