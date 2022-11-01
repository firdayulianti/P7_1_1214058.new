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

namespace P7_1_1214058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(775, 279);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNIM.Text != "")
            {
                if (tbNama.Text != "")
                {
                    if (rbL.Checked || rbP.Checked)
                    {
                        if (tbAlamat.Text != "")
                        {
                            if (cbProdi.Text != "")
                            {
                                if (tbTahunAkademik.Text != "")
                                {
                                    if (tbSemester.Text != "")
                                    {
                                    MessageBox.Show
                                    (" Lengkap",
                                    "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Size = new Size(816, 526);
                                    }
                                }
                                else
                                {
                                MessageBox.Show
                                ("Tahun akademik belum Diisi",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                            MessageBox.Show
                            ("Program studi belum Diisi",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                        MessageBox.Show
                        ("Alamat belum Diisi",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                    MessageBox.Show
                    ("Jenis kelamin belum Diisi",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                MessageBox.Show
                ("Nama belum Diisi",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
            MessageBox.Show
            ("NIM belum Diisi",
            "Informasi Data Submit",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbTahunAkademik_TextChanged(object sender, EventArgs e)
        {
            if (tbTahunAkademik.Text == "")
            {
                epWrong.SetError(tbTahunAkademik, "");
            }
            else
            {
                if (Regex.IsMatch(tbTahunAkademik.Text, @"^\d{4}/\d{4}$"))
                {
                    epWrong.SetError(tbTahunAkademik, "");
                }
                else
                {
                    epWrong.SetError(tbTahunAkademik, "Format tahun akademik salah!");
                }
            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {
            if (tbSemester.Text == "")
            {
                epWrong.SetError(tbSemester, "");
            }
            else
            {
                if ((tbSemester.Text).All(Char.IsNumber))
                {
                    epWrong.SetError(tbSemester, "");
                }
                else
                {
                    epWrong.SetError(tbSemester, "Inputan semester hanya boleh angka!");
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2006.Checked)
            {
                cbMatematika.Enabled = true; cbMatematika.Checked = false;
                cbPemrog1.Enabled = true; cbPemrog1.Checked = false;
                cbPemrog2.Enabled = true; cbPemrog2.Checked = false;
                cbPemrog3.Enabled = true; cbPemrog3.Checked = false;
                cbPemrog4.Enabled = true; cbPemrog4.Checked = false;
                cbPemrog5.Enabled = true; cbPemrog5.Checked = false;
                cbPemrog6.Enabled = true; cbPemrog6.Checked = false;
                cbPemrog7.Enabled = true; cbPemrog7.Checked = false;
                cbPenlog.Enabled = false; cbPenlog.Checked = false;
                cbJarkom.Enabled = true; cbJarkom.Checked = false;
                cbSisop.Enabled = true; cbSisop.Checked = false;
                cbMaranpa.Enabled = false; cbMaranpa.Checked = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2010.Checked)
            {
                cbMatematika.Enabled = false; cbMatematika.Checked = false;
                cbPemrog1.Enabled = true; cbPemrog1.Checked = false;
                cbPemrog2.Enabled = true; cbPemrog2.Checked = false;
                cbPemrog3.Enabled = true; cbPemrog3.Checked = false;
                cbPemrog4.Enabled = true; cbPemrog4.Checked = false;
                cbPemrog5.Enabled = true; cbPemrog5.Checked = false;
                cbPemrog6.Enabled = true; cbPemrog6.Checked = false;
                cbPemrog7.Enabled = true; cbPemrog7.Checked = false;
                cbPenlog.Enabled = false; cbPenlog.Checked = false;
                cbJarkom.Enabled = true; cbJarkom.Checked = false;
                cbSisop.Enabled = true; cbSisop.Checked = false;
                cbMaranpa.Enabled = true; cbMaranpa.Checked = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2014.Checked)
            {
                cbMatematika.Enabled = false; cbMatematika.Checked = false;
                cbPemrog1.Enabled = true; cbPemrog1.Checked = false;
                cbPemrog2.Enabled = true; cbPemrog2.Checked = false;
                cbPemrog3.Enabled = true; cbPemrog3.Checked = false;
                cbPemrog4.Enabled = true; cbPemrog4.Checked = false;
                cbPemrog5.Enabled = true; cbPemrog5.Checked = false;
                cbPemrog6.Enabled = true; cbPemrog6.Checked = false;
                cbPemrog7.Enabled = true; cbPemrog7.Checked = false;
                cbPenlog.Enabled = true; cbPenlog.Checked = false;
                cbJarkom.Enabled = true; cbJarkom.Checked = false;
                cbSisop.Enabled = true; cbSisop.Checked = false;
                cbMaranpa.Enabled = false; cbMaranpa.Checked = false;
            }
        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            String jeniskelamin = null;
            if (rbL.Checked)
            {
                jeniskelamin = rbL.Text;
            }
            else
            {
                jeniskelamin = rbP.Text;
            }
            String tahunajar = null;
            if (rb2006.Checked)
            {
                tahunajar = rb2006.Text;
            }
            else if (rb2010.Checked)
            {
                tahunajar = rb2010.Text;
            }
            else
            {
                tahunajar = rb2014.Text;
            }
            String matkul = null;
            if (cbMatematika.Checked)
            {
                matkul += cbMatematika.Text + ", ";
            }
            if (cbJarkom.Checked)
            {
                matkul += cbJarkom.Text + ", ";
            }
            if (cbPemrog1.Checked)
            {
                matkul += cbPemrog1.Text + ", ";
            }
            if (cbPemrog2.Checked)
            {
                matkul += cbPemrog2.Text + ", ";
            }
            if (cbPemrog3.Checked)
            {
                matkul += cbPemrog3.Text + ", ";
            }
            if (cbPemrog4.Checked)
            {
                matkul += cbPemrog4.Text + ", ";
            }
            if (cbPemrog5.Checked)
            {
                matkul += cbPemrog5.Text + ", ";
            }
            if (cbPemrog6.Checked)
            {
                matkul += cbPemrog6.Text + ", ";
            }
            if (cbPemrog7.Checked)
            {
                matkul += cbPemrog7.Text + ", ";
            }

            if (cbSisop.Checked)
            {
                matkul += cbSisop.Text + ", ";
            }

            if (cbMaranpa.Checked)
            {
                matkul += cbMaranpa.Text + ", ";
            }

            if (cbPenlog.Checked)
            {
                matkul += cbPenlog.Text + ", ";
            }
            MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nNIM: " + tbNIM.Text +
                    "\nJenis Kelamin: " + jeniskelamin +
                    "\nAlamat: " + tbAlamat.Text +
                    "\nProgram Studi: " + cbProdi.Text +
                    "\nTahun Akademik: " + tbTahunAkademik.Text +
                    "\nSemester: " + tbSemester.Text +
                    "\n" + "\n" +
                    "\nTahun Akademik: " + tahunajar +
                    "\nMata kuliah: " + matkul,

                    "Terima kasih telah menggunakan aplikasi kami",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bBatal_Click(object sender, EventArgs e)
        {
            tbNIM.Clear();
            tbNama.Clear();
            tbAlamat.Clear();
            rbL.Checked = false;
            rbP.Checked = false;
            cbProdi.ResetText();
            tbTahunAkademik.Clear();
            tbSemester.Clear();
            cbJarkom.Checked = false;
            cbSisop.Checked = false;
            cbPemrog1.Checked = false;
            cbPemrog2.Checked = false;
            cbPemrog3.Checked = false;
            cbPemrog4.Checked = false;
            cbPemrog5.Checked = false;
            cbPemrog6.Checked = false;
            cbPemrog7.Checked = false;
            cbMaranpa.Checked = false;
            cbPenlog.Checked = false;
            rb2006.Checked = false;
            rb2010.Checked = false;
            rb2014.Checked = false;

            this.Size = new Size(775, 279);
        }
    }
}
