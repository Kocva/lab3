
namespace lab3
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
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbDenum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbDenum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbDenum2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbRes1 = new System.Windows.Forms.TextBox();
            this.tbRes2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(96, 17);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 23);
            this.tbNum.TabIndex = 0;
            // 
            // tbDenum
            // 
            this.tbDenum.Location = new System.Drawing.Point(96, 46);
            this.tbDenum.Name = "tbDenum";
            this.tbDenum.Size = new System.Drawing.Size(100, 23);
            this.tbDenum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "числитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "знаменатель";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Упростить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(246, 17);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(100, 23);
            this.tbNum1.TabIndex = 5;
            // 
            // tbDenum1
            // 
            this.tbDenum1.Location = new System.Drawing.Point(246, 49);
            this.tbDenum1.Name = "tbDenum1";
            this.tbDenum1.Size = new System.Drawing.Size(100, 23);
            this.tbDenum1.TabIndex = 6;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(521, 20);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(100, 23);
            this.tbNum2.TabIndex = 7;
            // 
            // tbDenum2
            // 
            this.tbDenum2.Location = new System.Drawing.Point(521, 49);
            this.tbDenum2.Name = "tbDenum2";
            this.tbDenum2.Size = new System.Drawing.Size(100, 23);
            this.tbDenum2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "сложение",
            "вычитание",
            "умножение",
            "деление"});
            this.comboBox1.Location = new System.Drawing.Point(370, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // tbRes1
            // 
            this.tbRes1.Location = new System.Drawing.Point(679, 20);
            this.tbRes1.Name = "tbRes1";
            this.tbRes1.Size = new System.Drawing.Size(100, 23);
            this.tbRes1.TabIndex = 10;
            // 
            // tbRes2
            // 
            this.tbRes2.Location = new System.Drawing.Point(679, 48);
            this.tbRes2.Name = "tbRes2";
            this.tbRes2.Size = new System.Drawing.Size(100, 23);
            this.tbRes2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(638, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "=";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Вычислить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 254);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRes2);
            this.Controls.Add(this.tbRes1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbDenum2);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbDenum1);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDenum);
            this.Controls.Add(this.tbNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbDenum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbDenum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbDenum2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbRes1;
        private System.Windows.Forms.TextBox tbRes2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

