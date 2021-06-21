
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbPeppers = new System.Windows.Forms.CheckBox();
            this.cbMush = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbPepp = new System.Windows.Forms.CheckBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumber = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLarge);
            this.groupBox1.Controls.Add(this.rbMedium);
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Location = new System.Drawing.Point(28, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(7, 75);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(54, 19);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(7, 49);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(70, 19);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point(7, 23);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(54, 19);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbOlives);
            this.groupBox2.Controls.Add(this.cbPeppers);
            this.groupBox2.Controls.Add(this.cbMush);
            this.groupBox2.Controls.Add(this.cbSausage);
            this.groupBox2.Controls.Add(this.cbPepp);
            this.groupBox2.Location = new System.Drawing.Point(144, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings";
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Checked = true;
            this.cbOlives.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOlives.Location = new System.Drawing.Point(7, 117);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(58, 19);
            this.cbOlives.TabIndex = 4;
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            // 
            // cbPeppers
            // 
            this.cbPeppers.AutoSize = true;
            this.cbPeppers.Location = new System.Drawing.Point(7, 91);
            this.cbPeppers.Name = "cbPeppers";
            this.cbPeppers.Size = new System.Drawing.Size(68, 19);
            this.cbPeppers.TabIndex = 3;
            this.cbPeppers.Text = "Peppers";
            this.cbPeppers.UseVisualStyleBackColor = true;
            // 
            // cbMush
            // 
            this.cbMush.AutoSize = true;
            this.cbMush.Checked = true;
            this.cbMush.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMush.Location = new System.Drawing.Point(7, 65);
            this.cbMush.Name = "cbMush";
            this.cbMush.Size = new System.Drawing.Size(90, 19);
            this.cbMush.TabIndex = 2;
            this.cbMush.Text = "Mushrooms";
            this.cbMush.UseVisualStyleBackColor = true;
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(7, 39);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(69, 19);
            this.cbSausage.TabIndex = 1;
            this.cbSausage.Text = "Sausage";
            this.cbSausage.UseVisualStyleBackColor = true;
            // 
            // cbPepp
            // 
            this.cbPepp.AutoSize = true;
            this.cbPepp.Checked = true;
            this.cbPepp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPepp.Location = new System.Drawing.Point(7, 13);
            this.cbPepp.Name = "cbPepp";
            this.cbPepp.Size = new System.Drawing.Size(80, 19);
            this.cbPepp.TabIndex = 0;
            this.cbPepp.Text = "Pepperoni";
            this.cbPepp.UseVisualStyleBackColor = true;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(277, 69);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(121, 23);
            this.txbName.TabIndex = 2;
            this.txbName.Text = "Jan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Pizzas";
            // 
            // cbNumber
            // 
            this.cbNumber.FormattingEnabled = true;
            this.cbNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbNumber.Location = new System.Drawing.Point(277, 123);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(121, 23);
            this.cbNumber.TabIndex = 6;
            this.cbNumber.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total amount";
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(277, 170);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(121, 23);
            this.txbTotal.TabIndex = 8;
            this.txbTotal.Text = "28";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pizza order";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Name: ",
            "Number of Pizzas:",
            "Total amount:",
            "Size:",
            "Toppings:",
            "Toppings:",
            "Toppings:"});
            this.listBox1.Location = new System.Drawing.Point(488, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 169);
            this.listBox1.TabIndex = 10;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(277, 321);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(135, 38);
            this.btnRecord.TabIndex = 11;
            this.btnRecord.Text = "Record Transaction";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(556, 321);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(152, 38);
            this.btnComplete.TabIndex = 12;
            this.btnComplete.Text = "Complete Transaction";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbPeppers;
        private System.Windows.Forms.CheckBox cbMush;
        private System.Windows.Forms.CheckBox cbSausage;
        private System.Windows.Forms.CheckBox cbPepp;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnComplete;
    }
}

