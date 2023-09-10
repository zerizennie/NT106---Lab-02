namespace Lab02
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_mssv = new System.Windows.Forms.RichTextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.RichTextBox();
            this.tb_sdt = new System.Windows.Forms.RichTextBox();
            this.tb_DToan = new System.Windows.Forms.RichTextBox();
            this.tb_DVan = new System.Windows.Forms.RichTextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiemToan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiemVan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(38, 50);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(147, 46);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Nhập mảng SV";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(38, 119);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(147, 44);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Ghi file";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(38, 278);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(147, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xuất file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_mssv
            // 
            this.tb_mssv.Location = new System.Drawing.Point(497, 35);
            this.tb_mssv.Name = "tb_mssv";
            this.tb_mssv.Size = new System.Drawing.Size(199, 37);
            this.tb_mssv.TabIndex = 3;
            this.tb_mssv.Text = "";
            this.tb_mssv.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(775, 226);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(496, 288);
            this.output.TabIndex = 4;
            this.output.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tính toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(38, 349);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(147, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(981, 35);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(181, 37);
            this.tb_name.TabIndex = 7;
            this.tb_name.Text = "";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(497, 78);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(199, 37);
            this.tb_sdt.TabIndex = 8;
            this.tb_sdt.Text = "";
            // 
            // tb_DToan
            // 
            this.tb_DToan.Location = new System.Drawing.Point(981, 78);
            this.tb_DToan.Name = "tb_DToan";
            this.tb_DToan.Size = new System.Drawing.Size(181, 37);
            this.tb_DToan.TabIndex = 9;
            this.tb_DToan.Text = "";
            // 
            // tb_DVan
            // 
            this.tb_DVan.Location = new System.Drawing.Point(497, 125);
            this.tb_DVan.Name = "tb_DVan";
            this.tb_DVan.Size = new System.Drawing.Size(199, 37);
            this.tb_DVan.TabIndex = 10;
            this.tb_DVan.Text = "";
            this.tb_DVan.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.Hoten,
            this.SDT,
            this.DiemToan,
            this.DiemVan});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(243, 226);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(517, 288);
            this.listView.TabIndex = 11;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            // 
            // Hoten
            // 
            this.Hoten.Text = "HoTen";
            this.Hoten.Width = 100;
            // 
            // SDT
            // 
            this.SDT.Text = "SDT";
            this.SDT.Width = 100;
            // 
            // DiemToan
            // 
            this.DiemToan.Text = "DiemToan";
            this.DiemToan.Width = 100;
            // 
            // DiemVan
            // 
            this.DiemVan.Text = "DiemVan";
            this.DiemVan.Width = 94;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(388, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(79, 27);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "MSSV:";
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(874, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(88, 27);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Họ tên:";
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(405, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(62, 27);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "SĐT:";
            // 
            // textBox4
            // 
            this.textBox4.AllowDrop = true;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(835, 88);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(127, 27);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "Điểm toán:";
            // 
            // textBox5
            // 
            this.textBox5.AllowDrop = true;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(349, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(118, 27);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = "Điểm văn:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(329, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 151);
            this.panel1.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(349, 7);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(135, 22);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "Nhập thông tin SV";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(243, 190);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.ShortcutsEnabled = false;
            this.textBox7.Size = new System.Drawing.Size(97, 30);
            this.textBox7.TabIndex = 18;
            this.textBox7.Text = "Hiển thị";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(775, 190);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(73, 30);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "Output";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 526);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tb_DVan);
            this.Controls.Add(this.tb_DToan);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.tb_mssv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox tb_mssv;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox tb_name;
        private System.Windows.Forms.RichTextBox tb_sdt;
        private System.Windows.Forms.RichTextBox tb_DToan;
        private System.Windows.Forms.RichTextBox tb_DVan;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader Hoten;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.ColumnHeader DiemToan;
        private System.Windows.Forms.ColumnHeader DiemVan;
    }
}