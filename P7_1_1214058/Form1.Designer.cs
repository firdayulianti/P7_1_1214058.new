namespace P7_1_1214058
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbNIM = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbL = new System.Windows.Forms.RadioButton();
            this.rbP = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTahunAkademik = new System.Windows.Forms.TextBox();
            this.tbSemester = new System.Windows.Forms.TextBox();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bSimpan = new System.Windows.Forms.Button();
            this.bBatal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb2014 = new System.Windows.Forms.RadioButton();
            this.rb2010 = new System.Windows.Forms.RadioButton();
            this.rb2006 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMaranpa = new System.Windows.Forms.CheckBox();
            this.cbSisop = new System.Windows.Forms.CheckBox();
            this.cbJarkom = new System.Windows.Forms.CheckBox();
            this.cbPenlog = new System.Windows.Forms.CheckBox();
            this.cbPemrog7 = new System.Windows.Forms.CheckBox();
            this.cbPemrog6 = new System.Windows.Forms.CheckBox();
            this.cbPemrog5 = new System.Windows.Forms.CheckBox();
            this.cbPemrog4 = new System.Windows.Forms.CheckBox();
            this.cbPemrog3 = new System.Windows.Forms.CheckBox();
            this.cbPemrog2 = new System.Windows.Forms.CheckBox();
            this.cbPemrog1 = new System.Windows.Forms.CheckBox();
            this.cbMatematika = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNIM
            // 
            this.tbNIM.Location = new System.Drawing.Point(114, 56);
            this.tbNIM.Name = "tbNIM";
            this.tbNIM.Size = new System.Drawing.Size(205, 20);
            this.tbNIM.TabIndex = 0;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(114, 94);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(205, 20);
            this.tbNama.TabIndex = 1;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(114, 159);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(205, 53);
            this.tbAlamat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Program Studi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tahun Akademik";
            // 
            // rbL
            // 
            this.rbL.AutoSize = true;
            this.rbL.Location = new System.Drawing.Point(114, 126);
            this.rbL.Name = "rbL";
            this.rbL.Size = new System.Drawing.Size(70, 17);
            this.rbL.TabIndex = 11;
            this.rbL.TabStop = true;
            this.rbL.Text = "Laki - laki";
            this.rbL.UseVisualStyleBackColor = true;
            // 
            // rbP
            // 
            this.rbP.AutoSize = true;
            this.rbP.Location = new System.Drawing.Point(217, 126);
            this.rbP.Name = "rbP";
            this.rbP.Size = new System.Drawing.Size(79, 17);
            this.rbP.TabIndex = 12;
            this.rbP.TabStop = true;
            this.rbP.Text = "Perempuan";
            this.rbP.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Semester";
            // 
            // tbTahunAkademik
            // 
            this.tbTahunAkademik.Location = new System.Drawing.Point(538, 94);
            this.tbTahunAkademik.Name = "tbTahunAkademik";
            this.tbTahunAkademik.Size = new System.Drawing.Size(190, 20);
            this.tbTahunAkademik.TabIndex = 14;
            this.tbTahunAkademik.TextChanged += new System.EventHandler(this.tbTahunAkademik_TextChanged);
            // 
            // tbSemester
            // 
            this.tbSemester.Location = new System.Drawing.Point(538, 130);
            this.tbSemester.Name = "tbSemester";
            this.tbSemester.Size = new System.Drawing.Size(190, 20);
            this.tbSemester.TabIndex = 15;
            this.tbSemester.TextChanged += new System.EventHandler(this.tbSemester_TextChanged);
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Sistem Informatika",
            "Manajemen Informatika"});
            this.cbProdi.Location = new System.Drawing.Point(538, 55);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(190, 21);
            this.cbProdi.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pilih Mata Kuliah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSimpan
            // 
            this.bSimpan.Location = new System.Drawing.Point(179, 404);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(140, 23);
            this.bSimpan.TabIndex = 18;
            this.bSimpan.Text = "Simpan";
            this.bSimpan.UseVisualStyleBackColor = true;
            this.bSimpan.Click += new System.EventHandler(this.bSimpan_Click);
            // 
            // bBatal
            // 
            this.bBatal.Location = new System.Drawing.Point(343, 404);
            this.bBatal.Name = "bBatal";
            this.bBatal.Size = new System.Drawing.Size(140, 23);
            this.bBatal.TabIndex = 19;
            this.bBatal.Text = "Batal";
            this.bBatal.UseVisualStyleBackColor = true;
            this.bBatal.Click += new System.EventHandler(this.bBatal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb2014);
            this.groupBox1.Controls.Add(this.rb2010);
            this.groupBox1.Controls.Add(this.rb2006);
            this.groupBox1.Location = new System.Drawing.Point(29, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 128);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurikulum Pilihan";
            // 
            // rb2014
            // 
            this.rb2014.AutoSize = true;
            this.rb2014.Location = new System.Drawing.Point(7, 84);
            this.rb2014.Name = "rb2014";
            this.rb2014.Size = new System.Drawing.Size(98, 17);
            this.rb2014.TabIndex = 2;
            this.rb2014.TabStop = true;
            this.rb2014.Text = "Kurikulum 2014";
            this.rb2014.UseVisualStyleBackColor = true;
            this.rb2014.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rb2010
            // 
            this.rb2010.AutoSize = true;
            this.rb2010.Location = new System.Drawing.Point(6, 52);
            this.rb2010.Name = "rb2010";
            this.rb2010.Size = new System.Drawing.Size(98, 17);
            this.rb2010.TabIndex = 1;
            this.rb2010.TabStop = true;
            this.rb2010.Text = "Kurikulum 2010";
            this.rb2010.UseVisualStyleBackColor = true;
            this.rb2010.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rb2006
            // 
            this.rb2006.AutoSize = true;
            this.rb2006.Location = new System.Drawing.Point(7, 20);
            this.rb2006.Name = "rb2006";
            this.rb2006.Size = new System.Drawing.Size(98, 17);
            this.rb2006.TabIndex = 0;
            this.rb2006.TabStop = true;
            this.rb2006.Text = "Kurikulum 2006";
            this.rb2006.UseVisualStyleBackColor = true;
            this.rb2006.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMaranpa);
            this.groupBox2.Controls.Add(this.cbSisop);
            this.groupBox2.Controls.Add(this.cbJarkom);
            this.groupBox2.Controls.Add(this.cbPenlog);
            this.groupBox2.Controls.Add(this.cbPemrog7);
            this.groupBox2.Controls.Add(this.cbPemrog6);
            this.groupBox2.Controls.Add(this.cbPemrog5);
            this.groupBox2.Controls.Add(this.cbPemrog4);
            this.groupBox2.Controls.Add(this.cbPemrog3);
            this.groupBox2.Controls.Add(this.cbPemrog2);
            this.groupBox2.Controls.Add(this.cbPemrog1);
            this.groupBox2.Controls.Add(this.cbMatematika);
            this.groupBox2.Location = new System.Drawing.Point(306, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 128);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mata Kuliah Pilihan";
            // 
            // cbMaranpa
            // 
            this.cbMaranpa.AutoSize = true;
            this.cbMaranpa.Location = new System.Drawing.Point(242, 89);
            this.cbMaranpa.Name = "cbMaranpa";
            this.cbMaranpa.Size = new System.Drawing.Size(148, 17);
            this.cbMaranpa.TabIndex = 11;
            this.cbMaranpa.Text = "Manajemen Rantai Pasok";
            this.cbMaranpa.UseVisualStyleBackColor = true;
            // 
            // cbSisop
            // 
            this.cbSisop.AutoSize = true;
            this.cbSisop.Location = new System.Drawing.Point(242, 66);
            this.cbSisop.Name = "cbSisop";
            this.cbSisop.Size = new System.Drawing.Size(96, 17);
            this.cbSisop.TabIndex = 10;
            this.cbSisop.Text = "Sistem Operasi";
            this.cbSisop.UseVisualStyleBackColor = true;
            // 
            // cbJarkom
            // 
            this.cbJarkom.AutoSize = true;
            this.cbJarkom.Location = new System.Drawing.Point(242, 44);
            this.cbJarkom.Name = "cbJarkom";
            this.cbJarkom.Size = new System.Drawing.Size(114, 17);
            this.cbJarkom.TabIndex = 9;
            this.cbJarkom.Text = "Jaringan Komputer";
            this.cbJarkom.UseVisualStyleBackColor = true;
            // 
            // cbPenlog
            // 
            this.cbPenlog.AutoSize = true;
            this.cbPenlog.Location = new System.Drawing.Point(242, 21);
            this.cbPenlog.Name = "cbPenlog";
            this.cbPenlog.Size = new System.Drawing.Size(114, 17);
            this.cbPenlog.TabIndex = 8;
            this.cbPenlog.Text = "Pengantar Logistik";
            this.cbPenlog.UseVisualStyleBackColor = true;
            // 
            // cbPemrog7
            // 
            this.cbPemrog7.AutoSize = true;
            this.cbPemrog7.Location = new System.Drawing.Point(129, 89);
            this.cbPemrog7.Name = "cbPemrog7";
            this.cbPemrog7.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog7.TabIndex = 7;
            this.cbPemrog7.Text = "Pemrograman 7";
            this.cbPemrog7.UseVisualStyleBackColor = true;
            // 
            // cbPemrog6
            // 
            this.cbPemrog6.AutoSize = true;
            this.cbPemrog6.Location = new System.Drawing.Point(129, 67);
            this.cbPemrog6.Name = "cbPemrog6";
            this.cbPemrog6.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog6.TabIndex = 6;
            this.cbPemrog6.Text = "Pemrograman 6";
            this.cbPemrog6.UseVisualStyleBackColor = true;
            // 
            // cbPemrog5
            // 
            this.cbPemrog5.AutoSize = true;
            this.cbPemrog5.Location = new System.Drawing.Point(129, 44);
            this.cbPemrog5.Name = "cbPemrog5";
            this.cbPemrog5.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog5.TabIndex = 5;
            this.cbPemrog5.Text = "Pemrograman 5";
            this.cbPemrog5.UseVisualStyleBackColor = true;
            // 
            // cbPemrog4
            // 
            this.cbPemrog4.AutoSize = true;
            this.cbPemrog4.Location = new System.Drawing.Point(129, 21);
            this.cbPemrog4.Name = "cbPemrog4";
            this.cbPemrog4.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog4.TabIndex = 4;
            this.cbPemrog4.Text = "Pemrograman 4";
            this.cbPemrog4.UseVisualStyleBackColor = true;
            // 
            // cbPemrog3
            // 
            this.cbPemrog3.AutoSize = true;
            this.cbPemrog3.Location = new System.Drawing.Point(7, 89);
            this.cbPemrog3.Name = "cbPemrog3";
            this.cbPemrog3.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog3.TabIndex = 3;
            this.cbPemrog3.Text = "Pemrograman 3";
            this.cbPemrog3.UseVisualStyleBackColor = true;
            // 
            // cbPemrog2
            // 
            this.cbPemrog2.AutoSize = true;
            this.cbPemrog2.Location = new System.Drawing.Point(7, 66);
            this.cbPemrog2.Name = "cbPemrog2";
            this.cbPemrog2.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog2.TabIndex = 2;
            this.cbPemrog2.Text = "Pemrograman 2";
            this.cbPemrog2.UseVisualStyleBackColor = true;
            // 
            // cbPemrog1
            // 
            this.cbPemrog1.AutoSize = true;
            this.cbPemrog1.Location = new System.Drawing.Point(7, 43);
            this.cbPemrog1.Name = "cbPemrog1";
            this.cbPemrog1.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog1.TabIndex = 1;
            this.cbPemrog1.Text = "Pemrograman 1";
            this.cbPemrog1.UseVisualStyleBackColor = true;
            // 
            // cbMatematika
            // 
            this.cbMatematika.AutoSize = true;
            this.cbMatematika.Location = new System.Drawing.Point(7, 20);
            this.cbMatematika.Name = "cbMatematika";
            this.cbMatematika.Size = new System.Drawing.Size(81, 17);
            this.cbMatematika.TabIndex = 0;
            this.cbMatematika.Text = "Matematika";
            this.cbMatematika.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(273, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Pilihan Mata Kuliah Mahasiswa";
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 448);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bBatal);
            this.Controls.Add(this.bSimpan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.tbSemester);
            this.Controls.Add(this.tbTahunAkademik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbP);
            this.Controls.Add(this.rbL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNIM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNIM;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbL;
        private System.Windows.Forms.RadioButton rbP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTahunAkademik;
        private System.Windows.Forms.TextBox tbSemester;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bSimpan;
        private System.Windows.Forms.Button bBatal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb2014;
        private System.Windows.Forms.RadioButton rb2010;
        private System.Windows.Forms.RadioButton rb2006;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbPemrog3;
        private System.Windows.Forms.CheckBox cbPemrog2;
        private System.Windows.Forms.CheckBox cbPemrog1;
        private System.Windows.Forms.CheckBox cbMatematika;
        private System.Windows.Forms.CheckBox cbMaranpa;
        private System.Windows.Forms.CheckBox cbSisop;
        private System.Windows.Forms.CheckBox cbJarkom;
        private System.Windows.Forms.CheckBox cbPenlog;
        private System.Windows.Forms.CheckBox cbPemrog7;
        private System.Windows.Forms.CheckBox cbPemrog6;
        private System.Windows.Forms.CheckBox cbPemrog5;
        private System.Windows.Forms.CheckBox cbPemrog4;
        private System.Windows.Forms.ErrorProvider epWrong;
    }
}

