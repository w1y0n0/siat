namespace SIAT
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.ubahBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Prodi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // simpanBtn
            // 
            this.simpanBtn.Location = new System.Drawing.Point(197, 111);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(75, 23);
            this.simpanBtn.TabIndex = 5;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // ubahBtn
            // 
            this.ubahBtn.Location = new System.Drawing.Point(278, 111);
            this.ubahBtn.Name = "ubahBtn";
            this.ubahBtn.Size = new System.Drawing.Size(75, 23);
            this.ubahBtn.TabIndex = 6;
            this.ubahBtn.Text = "Ubah";
            this.ubahBtn.UseVisualStyleBackColor = true;
            this.ubahBtn.Click += new System.EventHandler(this.ubahBtn_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.Location = new System.Drawing.Point(359, 111);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(75, 23);
            this.hapusBtn.TabIndex = 7;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = true;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cKode,
            this.cNama});
            this.dataGridView1.Location = new System.Drawing.Point(67, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 200);
            this.dataGridView1.TabIndex = 8;
            // 
            // cKode
            // 
            this.cKode.DataPropertyName = "kode_prodi";
            this.cKode.HeaderText = "KODE";
            this.cKode.Name = "cKode";
            this.cKode.ReadOnly = true;
            this.cKode.Width = 75;
            // 
            // cNama
            // 
            this.cNama.DataPropertyName = "nama_prodi";
            this.cNama.HeaderText = "NAMA PRODI";
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.Width = 275;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.ubahBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button ubahBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
    }
}

