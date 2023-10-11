namespace Transkript
{
    partial class frmSil
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
            this.btnSil = new System.Windows.Forms.Button();
            this.lblderskodu = new System.Windows.Forms.Label();
            this.txtderskodu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Black;
            this.btngeri.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.Location = new System.Drawing.Point(17, 16);
            this.btngeri.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(62, 41);
            this.btngeri.TabIndex = 4;
            this.btngeri.Text = "<";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(90, 163);
            this.btnSil.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(188, 41);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblderskodu
            // 
            this.lblderskodu.AutoSize = true;
            this.lblderskodu.Location = new System.Drawing.Point(86, 106);
            this.lblderskodu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblderskodu.Name = "lblderskodu";
            this.lblderskodu.Size = new System.Drawing.Size(161, 24);
            this.lblderskodu.TabIndex = 31;
            this.lblderskodu.Text = "DERS KODU  :";
            // 
            // txtderskodu
            // 
            this.txtderskodu.Location = new System.Drawing.Point(303, 99);
            this.txtderskodu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtderskodu.Name = "txtderskodu";
            this.txtderskodu.Size = new System.Drawing.Size(188, 31);
            this.txtderskodu.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(303, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 41);
            this.button1.TabIndex = 32;
            this.button1.Text = "iptal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(590, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblderskodu);
            this.Controls.Add(this.txtderskodu);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btngeri);
            this.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmSil";
            this.Text = "frmSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblderskodu;
        private System.Windows.Forms.TextBox txtderskodu;
        private System.Windows.Forms.Button button1;
    }
}