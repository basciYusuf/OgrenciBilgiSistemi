namespace Transkript
{
    partial class DersBilgi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnListele1 = new System.Windows.Forms.Button();
            this.DataGridListele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListele)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele1
            // 
            this.btnListele1.BackColor = System.Drawing.Color.Black;
            this.btnListele1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele1.ForeColor = System.Drawing.Color.White;
            this.btnListele1.Location = new System.Drawing.Point(639, 84);
            this.btnListele1.Name = "btnListele1";
            this.btnListele1.Size = new System.Drawing.Size(176, 48);
            this.btnListele1.TabIndex = 65;
            this.btnListele1.Text = "Listele";
            this.btnListele1.UseVisualStyleBackColor = false;
            this.btnListele1.Click += new System.EventHandler(this.btnListele1_Click);
            // 
            // DataGridListele
            // 
            this.DataGridListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridListele.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridListele.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridListele.Location = new System.Drawing.Point(39, 169);
            this.DataGridListele.Name = "DataGridListele";
            this.DataGridListele.ReadOnly = true;
            this.DataGridListele.RowHeadersWidth = 51;
            this.DataGridListele.Size = new System.Drawing.Size(965, 413);
            this.DataGridListele.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 29);
            this.label1.TabIndex = 66;
            this.label1.Text = "Dersleri Görüntülemek İçin Tıklayın  :";
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.White;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.ForeColor = System.Drawing.Color.Black;
            this.btngeri.Location = new System.Drawing.Point(12, 12);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(32, 29);
            this.btngeri.TabIndex = 67;
            this.btngeri.Text = "<";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // DersBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1053, 610);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListele1);
            this.Controls.Add(this.DataGridListele);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DersBilgi";
            this.Text = "DersBilgi";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele1;
        private System.Windows.Forms.DataGridView DataGridListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngeri;
    }
}