namespace UserControl
{
    partial class AnotherForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(176, 65);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(60, 12);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(149, 21);
            this.departmentComboBox.TabIndex = 1;
            this.departmentComboBox.Text = "---Select---";
            // 
            // departmentListBox
            // 
            this.departmentListBox.FormattingEnabled = true;
            this.departmentListBox.Location = new System.Drawing.Point(27, 128);
            this.departmentListBox.Name = "departmentListBox";
            this.departmentListBox.Size = new System.Drawing.Size(211, 121);
            this.departmentListBox.TabIndex = 2;
            // 
            // AnotherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.departmentListBox);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.addButton);
            this.Name = "AnotherForm";
            this.Text = "AnotherForm";
            this.Load += new System.EventHandler(this.AnotherForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ListBox departmentListBox;
    }
}