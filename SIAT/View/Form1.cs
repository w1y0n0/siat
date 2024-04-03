using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIAT
{
    using Model;

    public partial class Form1 : Form
    {
        ProdiCls prodi = new ProdiCls();

        public Form1()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        void loadDGV()
        {
            dataGridView1.DataSource = prodi.tampilSemua();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prodi.apakahAda(textBox1.Text))
            {
                MessageBox.Show("Data sudah ada.");
            }
            else
            {
                MessageBox.Show("Data tidak ada.");
            }
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (!prodi.apakahAda(textBox1.Text))
            {
                prodi.Kode = textBox1.Text;
                prodi.Nama_Prodi = textBox2.Text;
                prodi.simpan();

                MessageBox.Show("Data berhasil disimpan.");
                bersihkan();
                textBox1.Focus();
                loadDGV();
            }
        }

        private void ubahBtn_Click(object sender, EventArgs e)
        {
            if (prodi.apakahAda(textBox1.Text))
            {
                if (MessageBox.Show("Yakin akan diubah ?", 
                    "Ubah Data", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    prodi.Nama_Prodi = textBox2.Text;
                    prodi.ubah(textBox1.Text);

                    MessageBox.Show("Data berhasil diubah.");
                    bersihkan();
                    textBox1.Focus();
                    loadDGV();
                }
            }
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            if (prodi.apakahAda(textBox1.Text))
            {
                if (MessageBox.Show("Yakin akan dihapus ?",
                    "Hapus Data",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    prodi.hapus(textBox1.Text);

                    MessageBox.Show("Data berhasil dihapus.");
                    bersihkan();
                    textBox1.Focus();
                    loadDGV();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }
    }
}
