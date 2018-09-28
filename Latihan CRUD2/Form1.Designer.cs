namespace Latihan_CRUD2
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
            this.dataGridKontak = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNama = new System.Windows.Forms.TextBox();
            this.textBInstansi = new System.Windows.Forms.TextBox();
            this.textTelepon = new System.Windows.Forms.TextBox();
            this.textSeluler = new System.Windows.Forms.TextBox();
            this.richTextAlamat = new System.Windows.Forms.RichTextBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKontak)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKontak
            // 
            this.dataGridKontak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKontak.Location = new System.Drawing.Point(12, 264);
            this.dataGridKontak.Name = "dataGridKontak";
            this.dataGridKontak.Size = new System.Drawing.Size(967, 227);
            this.dataGridKontak.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instansi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seluler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alamat";
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(73, 6);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(274, 20);
            this.textNama.TabIndex = 6;
            // 
            // textBInstansi
            // 
            this.textBInstansi.Location = new System.Drawing.Point(73, 30);
            this.textBInstansi.Name = "textBInstansi";
            this.textBInstansi.Size = new System.Drawing.Size(274, 20);
            this.textBInstansi.TabIndex = 7;
            // 
            // textTelepon
            // 
            this.textTelepon.Location = new System.Drawing.Point(73, 54);
            this.textTelepon.Name = "textTelepon";
            this.textTelepon.Size = new System.Drawing.Size(274, 20);
            this.textTelepon.TabIndex = 8;
            // 
            // textSeluler
            // 
            this.textSeluler.Location = new System.Drawing.Point(73, 78);
            this.textSeluler.Name = "textSeluler";
            this.textSeluler.Size = new System.Drawing.Size(274, 20);
            this.textSeluler.TabIndex = 9;
            // 
            // richTextAlamat
            // 
            this.richTextAlamat.Location = new System.Drawing.Point(73, 104);
            this.richTextAlamat.Name = "richTextAlamat";
            this.richTextAlamat.Size = new System.Drawing.Size(274, 143);
            this.richTextAlamat.TabIndex = 10;
            this.richTextAlamat.Text = "";
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(353, 224);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(75, 23);
            this.buttonTambah.TabIndex = 11;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 503);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.richTextAlamat);
            this.Controls.Add(this.textSeluler);
            this.Controls.Add(this.textTelepon);
            this.Controls.Add(this.textBInstansi);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridKontak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKontak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridKontak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.TextBox textBInstansi;
        private System.Windows.Forms.TextBox textTelepon;
        private System.Windows.Forms.TextBox textSeluler;
        private System.Windows.Forms.RichTextBox richTextAlamat;
        private System.Windows.Forms.Button buttonTambah;
    }
}

