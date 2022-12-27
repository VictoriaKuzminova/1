using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekz
{
    public partial class Form1 : Form
    {
        bool flag = false;
        bool select;
        public Form1()
        {
            InitializeComponent();
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кузьминова Виктория Викторовна" + "\n" + "Студентка группы ПКсп-120");
            return;
        }

        private void файл1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "TextFiles(*.html)|*.html|AllFiles(*.*)|*.*";
            dialog.ShowDialog();
            if (!flag)
            {
                this.Height += 100;
                flag = true;
            }
            string[] repSplit = dialog.FileName.Split('\\');
            string curFile = repSplit[repSplit.Length - 1];
            webBrowser1.Navigate(dialog.FileName);
            if (curFile == "1.html")
            {
                webBrowser1.Navigate(dialog.FileName);
                select = true;
            }
            else if (curFile == "2.html")
            {
                webBrowser1.Navigate(dialog.FileName);
                select = false;
            }
            else
            {
                MessageBox.Show($"Нет решения для {curFile}. Попробуйте выбрать файлы 1.html и 2.html");
            }
        }

    }
}
