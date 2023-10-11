namespace Transkript
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblhosgeldin = new System.Windows.Forms.Label();
            this.islemler = new System.Windows.Forms.GroupBox();
            this.btnogrkaydet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblganoyaz = new System.Windows.Forms.Label();
            this.lblgano = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.btnOgrenciBilgiGoster = new System.Windows.Forms.Button();
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.btnDersBilgiGoster = new System.Windows.Forms.Button();
            this.dataGridogrenci = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.islemler.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridogrenci)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblhosgeldin
            // 
            this.lblhosgeldin.AutoSize = true;
            this.lblhosgeldin.BackColor = System.Drawing.Color.Transparent;
            this.lblhosgeldin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblhosgeldin.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhosgeldin.ForeColor = System.Drawing.Color.White;
            this.lblhosgeldin.Location = new System.Drawing.Point(320, 12);
            this.lblhosgeldin.Name = "lblhosgeldin";
            this.lblhosgeldin.Size = new System.Drawing.Size(439, 52);
            this.lblhosgeldin.TabIndex = 0;
            this.lblhosgeldin.Text = "Ogrenci Bilgi Sistemi";
            // 
            // islemler
            // 
            this.islemler.BackColor = System.Drawing.Color.Black;
            this.islemler.Controls.Add(this.btnogrkaydet);
            this.islemler.Controls.Add(this.panel1);
            this.islemler.Controls.Add(this.txtOgrNo);
            this.islemler.Controls.Add(this.btnOgrenciBilgiGoster);
            this.islemler.Controls.Add(this.lblOgrNo);
            this.islemler.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.islemler.ForeColor = System.Drawing.Color.White;
            this.islemler.Location = new System.Drawing.Point(20, 107);
            this.islemler.Name = "islemler";
            this.islemler.Size = new System.Drawing.Size(465, 210);
            this.islemler.TabIndex = 6;
            this.islemler.TabStop = false;
            this.islemler.Text = "OTOMASYON SISTEMI";
            // 
            // btnogrkaydet
            // 
            this.btnogrkaydet.BackColor = System.Drawing.Color.Black;
            this.btnogrkaydet.Location = new System.Drawing.Point(286, 130);
            this.btnogrkaydet.Name = "btnogrkaydet";
            this.btnogrkaydet.Size = new System.Drawing.Size(172, 65);
            this.btnogrkaydet.TabIndex = 4;
            this.btnogrkaydet.Text = "ögrenci Kaydet";
            this.btnogrkaydet.UseVisualStyleBackColor = false;
            this.btnogrkaydet.Click += new System.EventHandler(this.btnogrkaydet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblganoyaz);
            this.panel1.Controls.Add(this.lblgano);
            this.panel1.Location = new System.Drawing.Point(333, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 85);
            this.panel1.TabIndex = 7;
            // 
            // lblganoyaz
            // 
            this.lblganoyaz.AutoSize = true;
            this.lblganoyaz.ForeColor = System.Drawing.Color.Black;
            this.lblganoyaz.Location = new System.Drawing.Point(22, 9);
            this.lblganoyaz.Name = "lblganoyaz";
            this.lblganoyaz.Size = new System.Drawing.Size(74, 24);
            this.lblganoyaz.TabIndex = 5;
            this.lblganoyaz.Text = "GANO ";
            // 
            // lblgano
            // 
            this.lblgano.AutoSize = true;
            this.lblgano.ForeColor = System.Drawing.Color.Black;
            this.lblgano.Location = new System.Drawing.Point(46, 50);
            this.lblgano.Name = "lblgano";
            this.lblgano.Size = new System.Drawing.Size(20, 24);
            this.lblgano.TabIndex = 6;
            this.lblgano.Text = "0";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(166, 56);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(100, 31);
            this.txtOgrNo.TabIndex = 2;
            this.txtOgrNo.TextChanged += new System.EventHandler(this.txtOgrNo_TextChanged);
            // 
            // btnOgrenciBilgiGoster
            // 
            this.btnOgrenciBilgiGoster.BackColor = System.Drawing.Color.Black;
            this.btnOgrenciBilgiGoster.Location = new System.Drawing.Point(32, 130);
            this.btnOgrenciBilgiGoster.Name = "btnOgrenciBilgiGoster";
            this.btnOgrenciBilgiGoster.Size = new System.Drawing.Size(172, 65);
            this.btnOgrenciBilgiGoster.TabIndex = 1;
            this.btnOgrenciBilgiGoster.Text = "Ögrenci Listele";
            this.btnOgrenciBilgiGoster.UseVisualStyleBackColor = false;
            this.btnOgrenciBilgiGoster.Click += new System.EventHandler(this.btnOgrenciBilgiGoster_Click);
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrNo.Location = new System.Drawing.Point(28, 64);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(110, 21);
            this.lblOgrNo.TabIndex = 0;
            this.lblOgrNo.Text = "Ögrenci No :";
            // 
            // btnDersBilgiGoster
            // 
            this.btnDersBilgiGoster.BackColor = System.Drawing.Color.Black;
            this.btnDersBilgiGoster.Location = new System.Drawing.Point(20, 46);
            this.btnDersBilgiGoster.Name = "btnDersBilgiGoster";
            this.btnDersBilgiGoster.Size = new System.Drawing.Size(471, 40);
            this.btnDersBilgiGoster.TabIndex = 3;
            this.btnDersBilgiGoster.Text = "Ders Bilgi Görüntüle";
            this.btnDersBilgiGoster.UseVisualStyleBackColor = false;
            this.btnDersBilgiGoster.Click += new System.EventHandler(this.btnDersBilgiGoster_Click);
            // 
            // dataGridogrenci
            // 
            this.dataGridogrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridogrenci.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridogrenci.Location = new System.Drawing.Point(20, 332);
            this.dataGridogrenci.Name = "dataGridogrenci";
            this.dataGridogrenci.ReadOnly = true;
            this.dataGridogrenci.RowHeadersWidth = 51;
            this.dataGridogrenci.Size = new System.Drawing.Size(1003, 253);
            this.dataGridogrenci.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnDersBilgiGoster);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(517, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(506, 210);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders İşlemleri";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Black;
            this.btnekle.Location = new System.Drawing.Point(356, 106);
            this.btnekle.Margin = new System.Windows.Forms.Padding(2);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(135, 89);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "Ders Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(188, 106);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(135, 89);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Ders Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(20, 106);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(135, 89);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Ders Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1035, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridogrenci);
            this.Controls.Add(this.islemler);
            this.Controls.Add(this.lblhosgeldin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.islemler.ResumeLayout(false);
            this.islemler.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridogrenci)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhosgeldin;
        private System.Windows.Forms.GroupBox islemler;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Button btnOgrenciBilgiGoster;
        private System.Windows.Forms.Label lblOgrNo;
        private System.Windows.Forms.DataGridView dataGridogrenci;
        private System.Windows.Forms.Button btnDersBilgiGoster;
        private System.Windows.Forms.Button btnogrkaydet;
        private System.Windows.Forms.Label lblgano;
        private System.Windows.Forms.Label lblganoyaz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel panel1;
    }
}

