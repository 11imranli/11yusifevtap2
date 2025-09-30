namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label3 = new Label();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 324);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Istifadeci melumati";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Gender";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(52, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "male";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(61, 37);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(56, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "qadin";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 59);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "language";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(3, 77);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(69, 19);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "ingilisce";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(78, 77);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(99, 19);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "Azerbaycanca";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 99);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Program biliyi";
            label3.Click += label3_Click;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(3, 117);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(48, 19);
            checkBox5.TabIndex = 7;
            checkBox5.Text = "c++";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(92, 117);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(47, 19);
            checkBox6.TabIndex = 8;
            checkBox6.Text = "java";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 139);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 9;
            label4.Text = "Yasadigi yer";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Berde", "Gence", "Yevlax" });
            comboBox1.Location = new Point(6, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 194);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 13;
            label5.Text = "Oxudugu yer";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "BMU", "BDU", "ADPU", "ADNSU", "MAA" });
            comboBox2.Location = new Point(3, 212);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(183, 251);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 15;
            button1.Text = "Message box";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 314);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private Button button1;
        private ComboBox comboBox2;
        private Label label5;
    }
}
