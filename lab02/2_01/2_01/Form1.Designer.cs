
namespace _2_01
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
            this.lblWzrost = new System.Windows.Forms.Label();
            this.lblPlec = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbKobieta = new System.Windows.Forms.RadioButton();
            this.rbMez = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxIde = new System.Windows.Forms.CheckBox();
            this.cbxStan = new System.Windows.Forms.CheckBox();
            this.btn = new System.Windows.Forms.Button();
            this.lblWynik = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWzrost
            // 
            this.lblWzrost.AutoSize = true;
            this.lblWzrost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWzrost.Location = new System.Drawing.Point(12, 50);
            this.lblWzrost.Name = "lblWzrost";
            this.lblWzrost.Size = new System.Drawing.Size(147, 21);
            this.lblWzrost.TabIndex = 0;
            this.lblWzrost.Text = "Podaj wzrost [cm]";
            // 
            // lblPlec
            // 
            this.lblPlec.AutoSize = true;
            this.lblPlec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlec.Location = new System.Drawing.Point(23, 117);
            this.lblPlec.Name = "lblPlec";
            this.lblPlec.Size = new System.Drawing.Size(42, 21);
            this.lblPlec.TabIndex = 1;
            this.lblPlec.Text = "Płeć";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // rbKobieta
            // 
            this.rbKobieta.AutoSize = true;
            this.rbKobieta.Location = new System.Drawing.Point(117, 117);
            this.rbKobieta.Name = "rbKobieta";
            this.rbKobieta.Size = new System.Drawing.Size(65, 19);
            this.rbKobieta.TabIndex = 3;
            this.rbKobieta.TabStop = true;
            this.rbKobieta.Text = "Kobieta";
            this.rbKobieta.UseVisualStyleBackColor = true;
            // 
            // rbMez
            // 
            this.rbMez.AutoSize = true;
            this.rbMez.Location = new System.Drawing.Point(188, 117);
            this.rbMez.Name = "rbMez";
            this.rbMez.Size = new System.Drawing.Size(82, 19);
            this.rbMez.TabIndex = 4;
            this.rbMez.TabStop = true;
            this.rbMez.Text = "Mężczyzna";
            this.rbMez.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxIde);
            this.groupBox1.Controls.Add(this.cbxStan);
            this.groupBox1.Location = new System.Drawing.Point(353, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waga";
            // 
            // cbxIde
            // 
            this.cbxIde.AutoSize = true;
            this.cbxIde.Location = new System.Drawing.Point(7, 58);
            this.cbxIde.Name = "cbxIde";
            this.cbxIde.Size = new System.Drawing.Size(64, 19);
            this.cbxIde.TabIndex = 1;
            this.cbxIde.Text = "Idealna";
            this.cbxIde.UseVisualStyleBackColor = true;
            // 
            // cbxStan
            // 
            this.cbxStan.AutoSize = true;
            this.cbxStan.Location = new System.Drawing.Point(7, 23);
            this.cbxStan.Name = "cbxStan";
            this.cbxStan.Size = new System.Drawing.Size(95, 19);
            this.cbxStan.TabIndex = 0;
            this.cbxStan.Text = "Standardowa";
            this.cbxStan.UseVisualStyleBackColor = true;
            this.cbxStan.CheckedChanged += new System.EventHandler(this.cbxStan_CheckedChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(181, 188);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 6;
            this.btn.Text = "Oblicz";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(13, 260);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(40, 15);
            this.lblWynik.TabIndex = 7;
            this.lblWynik.Text = "Wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 295);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbMez);
            this.Controls.Add(this.rbKobieta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPlec);
            this.Controls.Add(this.lblWzrost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWzrost;
        private System.Windows.Forms.Label lblPlec;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbKobieta;
        private System.Windows.Forms.RadioButton rbMez;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxIde;
        private System.Windows.Forms.CheckBox cbxStan;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblWynik;
    }
}

