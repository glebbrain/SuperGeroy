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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        public string SpecSimbol = "";
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    this.SpecSimbol = Environment.NewLine;
                    break;
                case 1:
                    this.SpecSimbol = "\t";
                    break;
                case 2:
                    this.SpecSimbol = "        ";
                    break;
                case 3:
                    this.SpecSimbol = "    ";
                    break;
                case 4:
                    this.SpecSimbol = "  ";
                    break;
                default:
                    this.SpecSimbol = "";
                    break;
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
                if (comboBox1.SelectedIndex == 0)
                {
                    if (textBox3.Text!="")
                    {
                        WriteResult(String.Join(Environment.NewLine, textBox1.Text.Split(new string[] { textBox3.Text }, StringSplitOptions.RemoveEmptyEntries)));
                    }
                    if (comboBox2.Text != "" && comboBox2.Text != "Спец. символы")
                    {
                        WriteResult(String.Join(Environment.NewLine, textBox1.Text.Split(new string[] { comboBox2.Text }, StringSplitOptions.RemoveEmptyEntries)));
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

        
    }
}
