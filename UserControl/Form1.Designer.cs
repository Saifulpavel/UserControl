namespace UserControl
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
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.maleCheckBox = new System.Windows.Forms.CheckBox();
            this.femaleCheckBox = new System.Windows.Forms.CheckBox();
            this.anotherFormButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(102, 12);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(149, 21);
            this.departmentComboBox.TabIndex = 0;
            this.departmentComboBox.Text = "---Select---";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(225, 39);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.otherRadioButton);
            this.groupBox1.Controls.Add(this.femaleRadioButton);
            this.groupBox1.Controls.Add(this.maleRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(60, 74);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(51, 17);
            this.otherRadioButton.TabIndex = 7;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(60, 46);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 6;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Location = new System.Drawing.Point(60, 21);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 5;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(246, 106);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(246, 129);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(246, 159);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // maleCheckBox
            // 
            this.maleCheckBox.AutoSize = true;
            this.maleCheckBox.Location = new System.Drawing.Point(24, 203);
            this.maleCheckBox.Name = "maleCheckBox";
            this.maleCheckBox.Size = new System.Drawing.Size(49, 17);
            this.maleCheckBox.TabIndex = 7;
            this.maleCheckBox.Text = "Male";
            this.maleCheckBox.UseVisualStyleBackColor = true;
            // 
            // femaleCheckBox
            // 
            this.femaleCheckBox.AutoSize = true;
            this.femaleCheckBox.Location = new System.Drawing.Point(24, 226);
            this.femaleCheckBox.Name = "femaleCheckBox";
            this.femaleCheckBox.Size = new System.Drawing.Size(60, 17);
            this.femaleCheckBox.TabIndex = 7;
            this.femaleCheckBox.Text = "Female";
            this.femaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // anotherFormButton
            // 
            this.anotherFormButton.Location = new System.Drawing.Point(185, 203);
            this.anotherFormButton.Name = "anotherFormButton";
            this.anotherFormButton.Size = new System.Drawing.Size(115, 23);
            this.anotherFormButton.TabIndex = 8;
            this.anotherFormButton.Text = "Another Form";
            this.anotherFormButton.UseVisualStyleBackColor = true;
            this.anotherFormButton.Click += new System.EventHandler(this.anotherFormButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.showButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 261);
            this.Controls.Add(this.anotherFormButton);
            this.Controls.Add(this.femaleCheckBox);
            this.Controls.Add(this.maleCheckBox);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.departmentComboBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox maleCheckBox;
        private System.Windows.Forms.CheckBox femaleCheckBox;
        private System.Windows.Forms.Button anotherFormButton;
    }
}

