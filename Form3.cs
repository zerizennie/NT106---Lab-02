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

namespace Lab02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            string str2 = "";
            string[] num = str.Split('\n');

            foreach (string n in num)
            {
                double result = Convert.ToDouble(new DataTable().Compute(n, null));
                str2 += n + " = " + result + "\n";
            }

            richTextBox2.Text = str2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = richTextBox2.Text;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt";
            saveFile.ShowDialog();
            FileStream fs = new FileStream(saveFile.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.WriteLine(str);
            sw.Close();
            fs.Close();
        }
    }
}
