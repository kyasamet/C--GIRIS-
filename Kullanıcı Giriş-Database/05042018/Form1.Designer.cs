namespace _05042018
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
            this.okulno = new System.Windows.Forms.TextBox();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.sinif = new System.Windows.Forms.TextBox();
            this.alan = new System.Windows.Forms.TextBox();
            this.bul = new System.Windows.Forms.Button();
            this.guncel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okulno
            // 
            this.okulno.Location = new System.Drawing.Point(147, 25);
            this.okulno.Name = "okulno";
            this.okulno.Size = new System.Drawing.Size(100, 20);
            this.okulno.TabIndex = 0;
            // 
            // adsoyad
            // 
            this.adsoyad.Location = new System.Drawing.Point(147, 71);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(100, 20);
            this.adsoyad.TabIndex = 1;
            // 
            // sinif
            // 
            this.sinif.Location = new System.Drawing.Point(147, 116);
            this.sinif.Name = "sinif";
            this.sinif.Size = new System.Drawing.Size(100, 20);
            this.sinif.TabIndex = 2;
            // 
            // alan
            // 
            this.alan.Location = new System.Drawing.Point(147, 155);
            this.alan.Name = "alan";
            this.alan.Size = new System.Drawing.Size(100, 20);
            this.alan.TabIndex = 3;
            // 
            // bul
            // 
            this.bul.Location = new System.Drawing.Point(29, 215);
            this.bul.Name = "bul";
            this.bul.Size = new System.Drawing.Size(83, 35);
            this.bul.TabIndex = 4;
            this.bul.Text = "Search";
            this.bul.UseVisualStyleBackColor = true;
            this.bul.Click += new System.EventHandler(this.bul_Click);
            // 
            // guncel
            // 
            this.guncel.Location = new System.Drawing.Point(187, 215);
            this.guncel.Name = "guncel";
            this.guncel.Size = new System.Drawing.Size(85, 34);
            this.guncel.TabIndex = 5;
            this.guncel.Text = "Update";
            this.guncel.UseVisualStyleBackColor = true;
            this.guncel.Click += new System.EventHandler(this.guncel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "School No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name And Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guncel);
            this.Controls.Add(this.bul);
            this.Controls.Add(this.alan);
            this.Controls.Add(this.sinif);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.okulno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox okulno;
        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.TextBox sinif;
        private System.Windows.Forms.TextBox alan;
        private System.Windows.Forms.Button bul;
        private System.Windows.Forms.Button guncel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}