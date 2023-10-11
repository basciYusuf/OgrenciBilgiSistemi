namespace Transkript
{
    partial class frmGuncelle
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
            this.btngeri = new System.Windows.Forms.Button();
            this.lblegtsoyad = new System.Windows.Forms.Label();
            this.lblegtad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldersadi = new System.Windows.Forms.Label();
            this.lblderskodu = new System.Windows.Forms.Label();
            this.txtdonem = new System.Windows.Forms.TextBox();
            this.txtegtsoyad = new System.Windows.Forms.TextBox();
            this.txtakts = new System.Windows.Forms.TextBox();
            this.txtegtad = new System.Windows.Forms.TextBox();
            this.txtkredi = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtkod = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Black;
            this.btngeri.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.Location = new System.Drawing.Point(16, 15);
            this.btngeri.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(57, 54);
            this.btngeri.TabIndex = 4;
            this.btngeri.Text = "<";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // lblegtsoyad
            // 
            this.lblegtsoyad.AutoSize = true;
            this.lblegtsoyad.Location = new System.Drawing.Point(145, 522);
            this.lblegtsoyad.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblegtsoyad.Name = "lblegtsoyad";
            this.lblegtsoyad.Size = new System.Drawing.Size(182, 25);
            this.lblegtsoyad.TabIndex = 36;
            this.lblegtsoyad.Text = "EGT.   SOYAD :";
            // 
            // lblegtad
            // 
            this.lblegtad.AutoSize = true;
            this.lblegtad.Location = new System.Drawing.Point(145, 454);
            this.lblegtad.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblegtad.Name = "lblegtad";
            this.lblegtad.Size = new System.Drawing.Size(135, 25);
            this.lblegtad.TabIndex = 35;
            this.lblegtad.Text = "EGT.   AD :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "DERS DONEM  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "DERS AKTS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "DERS KREDISI :";
            // 
            // lbldersadi
            // 
            this.lbldersadi.AutoSize = true;
            this.lbldersadi.Location = new System.Drawing.Point(145, 170);
            this.lbldersadi.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbldersadi.Name = "lbldersadi";
            this.lbldersadi.Size = new System.Drawing.Size(150, 25);
            this.lbldersadi.TabIndex = 30;
            this.lbldersadi.Text = "DERS ADI  :";
            // 
            // lblderskodu
            // 
            this.lblderskodu.AutoSize = true;
            this.lblderskodu.Location = new System.Drawing.Point(145, 97);
            this.lblderskodu.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblderskodu.Name = "lblderskodu";
            this.lblderskodu.Size = new System.Drawing.Size(173, 25);
            this.lblderskodu.TabIndex = 29;
            this.lblderskodu.Text = "DERS KODU  :";
            // 
            // txtdonem
            // 
            this.txtdonem.Enabled = false;
            this.txtdonem.Location = new System.Drawing.Point(436, 372);
            this.txtdonem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtdonem.Name = "txtdonem";
            this.txtdonem.Size = new System.Drawing.Size(194, 32);
            this.txtdonem.TabIndex = 28;
            // 
            // txtegtsoyad
            // 
            this.txtegtsoyad.Enabled = false;
            this.txtegtsoyad.Location = new System.Drawing.Point(436, 509);
            this.txtegtsoyad.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtegtsoyad.Name = "txtegtsoyad";
            this.txtegtsoyad.Size = new System.Drawing.Size(194, 32);
            this.txtegtsoyad.TabIndex = 27;
            // 
            // txtakts
            // 
            this.txtakts.Enabled = false;
            this.txtakts.Location = new System.Drawing.Point(436, 306);
            this.txtakts.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtakts.Name = "txtakts";
            this.txtakts.Size = new System.Drawing.Size(194, 32);
            this.txtakts.TabIndex = 25;
            // 
            // txtegtad
            // 
            this.txtegtad.Enabled = false;
            this.txtegtad.Location = new System.Drawing.Point(436, 442);
            this.txtegtad.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtegtad.Name = "txtegtad";
            this.txtegtad.Size = new System.Drawing.Size(194, 32);
            this.txtegtad.TabIndex = 24;
            // 
            // txtkredi
            // 
            this.txtkredi.Enabled = false;
            this.txtkredi.Location = new System.Drawing.Point(436, 231);
            this.txtkredi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtkredi.Name = "txtkredi";
            this.txtkredi.Size = new System.Drawing.Size(194, 32);
            this.txtkredi.TabIndex = 23;
            // 
            // txtad
            // 
            this.txtad.Enabled = false;
            this.txtad.Location = new System.Drawing.Point(436, 156);
            this.txtad.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(194, 32);
            this.txtad.TabIndex = 22;
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(436, 84);
            this.txtkod.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(194, 32);
            this.txtkod.TabIndex = 21;
            this.txtkod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(150, 614);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(188, 67);
            this.btnGuncelle.TabIndex = 37;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Black;
            this.btnIptal.Location = new System.Drawing.Point(436, 614);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(194, 67);
            this.btnIptal.TabIndex = 38;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // frmGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(743, 748);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblegtsoyad);
            this.Controls.Add(this.lblegtad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbldersadi);
            this.Controls.Add(this.lblderskodu);
            this.Controls.Add(this.txtdonem);
            this.Controls.Add(this.txtegtsoyad);
            this.Controls.Add(this.txtakts);
            this.Controls.Add(this.txtegtad);
            this.Controls.Add(this.txtkredi);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtkod);
            this.Controls.Add(this.btngeri);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmGuncelle";
            this.Text = "frmGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label lblegtsoyad;
        private System.Windows.Forms.Label lblegtad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldersadi;
        private System.Windows.Forms.Label lblderskodu;
        private System.Windows.Forms.TextBox txtdonem;
        private System.Windows.Forms.TextBox txtegtsoyad;
        private System.Windows.Forms.TextBox txtakts;
        private System.Windows.Forms.TextBox txtegtad;
        private System.Windows.Forms.TextBox txtkredi;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnIptal;
    }
}