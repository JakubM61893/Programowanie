
namespace zad1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx = new System.Windows.Forms.TextBox();
            this.txby = new System.Windows.Forms.TextBox();
            this.txbz = new System.Windows.Forms.TextBox();
            this.txbWynik = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnIloczyn = new System.Windows.Forms.Button();
            this.btnWyjscie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wynik";
            // 
            // txbx
            // 
            this.txbx.Location = new System.Drawing.Point(174, 43);
            this.txbx.Name = "txbx";
            this.txbx.Size = new System.Drawing.Size(100, 23);
            this.txbx.TabIndex = 4;
            // 
            // txby
            // 
            this.txby.Location = new System.Drawing.Point(174, 91);
            this.txby.Name = "txby";
            this.txby.Size = new System.Drawing.Size(100, 23);
            this.txby.TabIndex = 5;
            // 
            // txbz
            // 
            this.txbz.Location = new System.Drawing.Point(174, 162);
            this.txbz.Name = "txbz";
            this.txbz.Size = new System.Drawing.Size(100, 23);
            this.txbz.TabIndex = 6;
            // 
            // txbWynik
            // 
            this.txbWynik.Location = new System.Drawing.Point(174, 221);
            this.txbWynik.Name = "txbWynik";
            this.txbWynik.Size = new System.Drawing.Size(100, 23);
            this.txbWynik.TabIndex = 7;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(343, 82);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 8;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnIloczyn
            // 
            this.btnIloczyn.Location = new System.Drawing.Point(343, 142);
            this.btnIloczyn.Name = "btnIloczyn";
            this.btnIloczyn.Size = new System.Drawing.Size(75, 23);
            this.btnIloczyn.TabIndex = 9;
            this.btnIloczyn.Text = "Iloczyn";
            this.btnIloczyn.UseVisualStyleBackColor = true;
            this.btnIloczyn.Click += new System.EventHandler(this.btnIloczyn_Click);
            // 
            // btnWyjscie
            // 
            this.btnWyjscie.Location = new System.Drawing.Point(343, 213);
            this.btnWyjscie.Name = "btnWyjscie";
            this.btnWyjscie.Size = new System.Drawing.Size(75, 23);
            this.btnWyjscie.TabIndex = 10;
            this.btnWyjscie.Text = "Wyjście";
            this.btnWyjscie.UseVisualStyleBackColor = true;
            this.btnWyjscie.Click += new System.EventHandler(this.btnWyjscie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 317);
            this.Controls.Add(this.btnWyjscie);
            this.Controls.Add(this.btnIloczyn);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txbWynik);
            this.Controls.Add(this.txbz);
            this.Controls.Add(this.txby);
            this.Controls.Add(this.txbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx;
        private System.Windows.Forms.TextBox txby;
        private System.Windows.Forms.TextBox txbz;
        private System.Windows.Forms.TextBox txbWynik;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnIloczyn;
        private System.Windows.Forms.Button btnWyjscie;
    }
}

