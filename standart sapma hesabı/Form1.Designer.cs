
namespace standart_sapma_hesabı
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
            this.btnStandarts = new System.Windows.Forms.Button();
            this.lblrecursive = new System.Windows.Forms.Label();
            this.lbliteratif = new System.Windows.Forms.Label();
            this.txtRecursive = new System.Windows.Forms.TextBox();
            this.txtIteratif = new System.Windows.Forms.TextBox();
            this.txtSayigir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStandarts
            // 
            this.btnStandarts.Location = new System.Drawing.Point(269, 57);
            this.btnStandarts.Name = "btnStandarts";
            this.btnStandarts.Size = new System.Drawing.Size(181, 34);
            this.btnStandarts.TabIndex = 1;
            this.btnStandarts.Text = "Standart sapma";
            this.btnStandarts.UseVisualStyleBackColor = true;
            this.btnStandarts.Click += new System.EventHandler(this.btnStandarts_Click);
            // 
            // lblrecursive
            // 
            this.lblrecursive.AutoSize = true;
            this.lblrecursive.Location = new System.Drawing.Point(266, 148);
            this.lblrecursive.Name = "lblrecursive";
            this.lblrecursive.Size = new System.Drawing.Size(71, 17);
            this.lblrecursive.TabIndex = 2;
            this.lblrecursive.Text = "Recursive";
            // 
            // lbliteratif
            // 
            this.lbliteratif.AutoSize = true;
            this.lbliteratif.Location = new System.Drawing.Point(266, 249);
            this.lbliteratif.Name = "lbliteratif";
            this.lbliteratif.Size = new System.Drawing.Size(47, 17);
            this.lbliteratif.TabIndex = 2;
            this.lbliteratif.Text = "İteratif";
            // 
            // txtRecursive
            // 
            this.txtRecursive.Location = new System.Drawing.Point(269, 177);
            this.txtRecursive.Multiline = true;
            this.txtRecursive.Name = "txtRecursive";
            this.txtRecursive.Size = new System.Drawing.Size(142, 33);
            this.txtRecursive.TabIndex = 0;
            // 
            // txtIteratif
            // 
            this.txtIteratif.Location = new System.Drawing.Point(269, 278);
            this.txtIteratif.Multiline = true;
            this.txtIteratif.Name = "txtIteratif";
            this.txtIteratif.Size = new System.Drawing.Size(142, 33);
            this.txtIteratif.TabIndex = 0;
            // 
            // txtSayigir
            // 
            this.txtSayigir.Location = new System.Drawing.Point(58, 69);
            this.txtSayigir.Name = "txtSayigir";
            this.txtSayigir.Size = new System.Drawing.Size(100, 22);
            this.txtSayigir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sayı  Giriniz";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(58, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 212);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 386);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayigir);
            this.Controls.Add(this.lbliteratif);
            this.Controls.Add(this.lblrecursive);
            this.Controls.Add(this.btnStandarts);
            this.Controls.Add(this.txtIteratif);
            this.Controls.Add(this.txtRecursive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStandarts;
        private System.Windows.Forms.Label lblrecursive;
        private System.Windows.Forms.Label lbliteratif;
        private System.Windows.Forms.TextBox txtRecursive;
        private System.Windows.Forms.TextBox txtIteratif;
        private System.Windows.Forms.TextBox txtSayigir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

