namespace W7__Latihan_Senin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_masukkanklm = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_hurufsebelum = new System.Windows.Forms.TextBox();
            this.btn_konversi = new System.Windows.Forms.Button();
            this.lbl_masukkanhrf = new System.Windows.Forms.Label();
            this.txt_hurufsesudah = new System.Windows.Forms.TextBox();
            this.lbl_menjadi = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.lbl_hasil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_masukkanklm
            // 
            this.lbl_masukkanklm.AutoSize = true;
            this.lbl_masukkanklm.Location = new System.Drawing.Point(39, 64);
            this.lbl_masukkanklm.Name = "lbl_masukkanklm";
            this.lbl_masukkanklm.Size = new System.Drawing.Size(146, 20);
            this.lbl_masukkanklm.TabIndex = 1;
            this.lbl_masukkanklm.Text = "Masukkan Kalimat: ";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(191, 61);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(659, 26);
            this.txt_input.TabIndex = 2;
            // 
            // txt_hurufsebelum
            // 
            this.txt_hurufsebelum.Location = new System.Drawing.Point(191, 131);
            this.txt_hurufsebelum.Name = "txt_hurufsebelum";
            this.txt_hurufsebelum.Size = new System.Drawing.Size(166, 26);
            this.txt_hurufsebelum.TabIndex = 3;
            // 
            // btn_konversi
            // 
            this.btn_konversi.Location = new System.Drawing.Point(191, 195);
            this.btn_konversi.Name = "btn_konversi";
            this.btn_konversi.Size = new System.Drawing.Size(659, 42);
            this.btn_konversi.TabIndex = 4;
            this.btn_konversi.Text = "Konversi!";
            this.btn_konversi.UseVisualStyleBackColor = true;
            this.btn_konversi.Click += new System.EventHandler(this.btn_konversi_Click);
            // 
            // lbl_masukkanhrf
            // 
            this.lbl_masukkanhrf.AutoSize = true;
            this.lbl_masukkanhrf.Location = new System.Drawing.Point(39, 134);
            this.lbl_masukkanhrf.Name = "lbl_masukkanhrf";
            this.lbl_masukkanhrf.Size = new System.Drawing.Size(134, 20);
            this.lbl_masukkanhrf.TabIndex = 5;
            this.lbl_masukkanhrf.Text = "Masukkan Huruf: ";
            // 
            // txt_hurufsesudah
            // 
            this.txt_hurufsesudah.Location = new System.Drawing.Point(684, 131);
            this.txt_hurufsesudah.Name = "txt_hurufsesudah";
            this.txt_hurufsesudah.Size = new System.Drawing.Size(166, 26);
            this.txt_hurufsesudah.TabIndex = 6;
            // 
            // lbl_menjadi
            // 
            this.lbl_menjadi.AutoSize = true;
            this.lbl_menjadi.Location = new System.Drawing.Point(606, 134);
            this.lbl_menjadi.Name = "lbl_menjadi";
            this.lbl_menjadi.Size = new System.Drawing.Size(72, 20);
            this.lbl_menjadi.TabIndex = 7;
            this.lbl_menjadi.Text = "Menjadi: ";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(39, 275);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(52, 20);
            this.lbl_output.TabIndex = 8;
            this.lbl_output.Text = "Hasil: ";
            // 
            // lbl_hasil
            // 
            this.lbl_hasil.AutoSize = true;
            this.lbl_hasil.Location = new System.Drawing.Point(187, 275);
            this.lbl_hasil.Name = "lbl_hasil";
            this.lbl_hasil.Size = new System.Drawing.Size(21, 20);
            this.lbl_hasil.TabIndex = 9;
            this.lbl_hasil.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_hasil);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_menjadi);
            this.Controls.Add(this.txt_hurufsesudah);
            this.Controls.Add(this.lbl_masukkanhrf);
            this.Controls.Add(this.btn_konversi);
            this.Controls.Add(this.txt_hurufsebelum);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_masukkanklm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quiz Panda by Kyrell ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_masukkanklm;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_hurufsebelum;
        private System.Windows.Forms.Button btn_konversi;
        private System.Windows.Forms.Label lbl_masukkanhrf;
        private System.Windows.Forms.TextBox txt_hurufsesudah;
        private System.Windows.Forms.Label lbl_menjadi;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label lbl_hasil;
        private System.Windows.Forms.Label label1;
    }
}

