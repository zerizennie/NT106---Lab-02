using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab02
{
    public partial class Form5 : Form
    {
        

        public Form5()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();
        private void LoadData()
        {
            listView.Items.Clear();
            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.MSSV);
                item.SubItems.Add(student.HoTen);
                item.SubItems.Add(student.SDT);
                item.SubItems.Add(student.DToan.ToString());
                item.SubItems.Add(student.DVan.ToString());
                listView.Items.Add(item);

            }
            listView.Refresh();
        }
        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Student student = new Student
            {
                MSSV = tb_mssv.Text,
                HoTen = tb_name.Text,
                SDT = tb_sdt.Text,
                DToan = float.Parse(tb_DToan.Text),
                DVan = float.Parse(tb_DVan.Text)
            };
            students.Add(student);
            LoadData();



        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Student TempStudent = new Student();
                TempStudent.SetSt(tb_mssv.Text, tb_name.Text, tb_sdt.Text, float.Parse(tb_DToan.Text.Trim()), float.Parse(tb_DVan.Text.Trim()));
                students.Add(TempStudent);
                FileStream fi = new FileStream("input.txt", FileMode.OpenOrCreate);
                BinaryFormatter bi = new BinaryFormatter();
                bi.Serialize(fi, students);
                fi.Close();
                MessageBox.Show("Học viên đã được lưu vào file input.txt. Nhấn button Tính ĐTB để tính ĐTB");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (Student St in students)
                {
                    St.Tinh();
                }
                FileStream fi = new FileStream("output.txt", FileMode.Create);
                BinaryFormatter bi = new BinaryFormatter();
                bi.Serialize(fi, students);
                fi.Close();
                MessageBox.Show("ĐTB đã được lưu vào file output.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.Clear();
            FileStream fi = null;
            try
            {
                fi = new FileStream("output.txt", FileMode.Open);
                BinaryFormatter bi = new BinaryFormatter();
                List<Student> list = new List<Student>();
                list = (List<Student>)bi.Deserialize(fi);
                for (int i = 0; i < list.Count - 1; i++)
                {
                    output.Text += list[i].GetSt().ToString() + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_mssv.Clear();
            tb_name.Clear();
            tb_sdt.Clear();
            tb_DToan.Clear();
            tb_DVan.Clear();
            listView.Items.Clear();
            output.Clear();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
