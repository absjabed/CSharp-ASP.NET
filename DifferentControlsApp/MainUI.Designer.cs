namespace DifferentControlsApp
{
    partial class MainUI
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
            this.ComboBoxGroupBox = new System.Windows.Forms.GroupBox();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.showComboBoxButton = new System.Windows.Forms.Button();
            this.RadioButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.OddRadioButton = new System.Windows.Forms.RadioButton();
            this.EvenRadioButton = new System.Windows.Forms.RadioButton();
            this.showRadioButtonButton = new System.Windows.Forms.Button();
            this.CheckBoxGroupBox = new System.Windows.Forms.GroupBox();
            this.OddCheckBox = new System.Windows.Forms.CheckBox();
            this.EvenCheckBox = new System.Windows.Forms.CheckBox();
            this.showCheckBoxButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.ComboBoxGroupBox.SuspendLayout();
            this.RadioButtonGroupBox.SuspendLayout();
            this.CheckBoxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxGroupBox
            // 
            this.ComboBoxGroupBox.Controls.Add(this.numberComboBox);
            this.ComboBoxGroupBox.Controls.Add(this.showComboBoxButton);
            this.ComboBoxGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ComboBoxGroupBox.Name = "ComboBoxGroupBox";
            this.ComboBoxGroupBox.Size = new System.Drawing.Size(351, 140);
            this.ComboBoxGroupBox.TabIndex = 0;
            this.ComboBoxGroupBox.TabStop = false;
            this.ComboBoxGroupBox.Text = "Combo Box";
            // 
            // numberComboBox
            // 
            this.numberComboBox.FormattingEnabled = true;
            this.numberComboBox.Items.AddRange(new object[] {
            "103",
            "102",
            "101",
            "105"});
            this.numberComboBox.Location = new System.Drawing.Point(45, 62);
            this.numberComboBox.Name = "numberComboBox";
            this.numberComboBox.Size = new System.Drawing.Size(121, 23);
            this.numberComboBox.TabIndex = 1;
            // 
            // showComboBoxButton
            // 
            this.showComboBoxButton.Location = new System.Drawing.Point(199, 62);
            this.showComboBoxButton.Name = "showComboBoxButton";
            this.showComboBoxButton.Size = new System.Drawing.Size(108, 23);
            this.showComboBoxButton.TabIndex = 0;
            this.showComboBoxButton.Text = "Show";
            this.showComboBoxButton.UseVisualStyleBackColor = true;
            this.showComboBoxButton.Click += new System.EventHandler(this.showComboBoxButton_Click);
            // 
            // RadioButtonGroupBox
            // 
            this.RadioButtonGroupBox.Controls.Add(this.OddRadioButton);
            this.RadioButtonGroupBox.Controls.Add(this.EvenRadioButton);
            this.RadioButtonGroupBox.Controls.Add(this.showRadioButtonButton);
            this.RadioButtonGroupBox.Location = new System.Drawing.Point(12, 158);
            this.RadioButtonGroupBox.Name = "RadioButtonGroupBox";
            this.RadioButtonGroupBox.Size = new System.Drawing.Size(351, 140);
            this.RadioButtonGroupBox.TabIndex = 0;
            this.RadioButtonGroupBox.TabStop = false;
            this.RadioButtonGroupBox.Text = "Radio Button";
            // 
            // OddRadioButton
            // 
            this.OddRadioButton.AutoSize = true;
            this.OddRadioButton.Location = new System.Drawing.Point(147, 40);
            this.OddRadioButton.Name = "OddRadioButton";
            this.OddRadioButton.Size = new System.Drawing.Size(48, 19);
            this.OddRadioButton.TabIndex = 1;
            this.OddRadioButton.TabStop = true;
            this.OddRadioButton.Text = "Odd";
            this.OddRadioButton.UseVisualStyleBackColor = true;
            // 
            // EvenRadioButton
            // 
            this.EvenRadioButton.AutoSize = true;
            this.EvenRadioButton.Location = new System.Drawing.Point(45, 40);
            this.EvenRadioButton.Name = "EvenRadioButton";
            this.EvenRadioButton.Size = new System.Drawing.Size(52, 19);
            this.EvenRadioButton.TabIndex = 1;
            this.EvenRadioButton.TabStop = true;
            this.EvenRadioButton.Text = "Even";
            this.EvenRadioButton.UseVisualStyleBackColor = true;
            // 
            // showRadioButtonButton
            // 
            this.showRadioButtonButton.Location = new System.Drawing.Point(91, 88);
            this.showRadioButtonButton.Name = "showRadioButtonButton";
            this.showRadioButtonButton.Size = new System.Drawing.Size(75, 23);
            this.showRadioButtonButton.TabIndex = 0;
            this.showRadioButtonButton.Text = "Show";
            this.showRadioButtonButton.UseVisualStyleBackColor = true;
            this.showRadioButtonButton.Click += new System.EventHandler(this.showRadioButtonButton_Click);
            // 
            // CheckBoxGroupBox
            // 
            this.CheckBoxGroupBox.Controls.Add(this.OddCheckBox);
            this.CheckBoxGroupBox.Controls.Add(this.EvenCheckBox);
            this.CheckBoxGroupBox.Controls.Add(this.showCheckBoxButton);
            this.CheckBoxGroupBox.Location = new System.Drawing.Point(12, 304);
            this.CheckBoxGroupBox.Name = "CheckBoxGroupBox";
            this.CheckBoxGroupBox.Size = new System.Drawing.Size(351, 140);
            this.CheckBoxGroupBox.TabIndex = 0;
            this.CheckBoxGroupBox.TabStop = false;
            this.CheckBoxGroupBox.Text = "Chack Box";
            // 
            // OddCheckBox
            // 
            this.OddCheckBox.AutoSize = true;
            this.OddCheckBox.Location = new System.Drawing.Point(147, 32);
            this.OddCheckBox.Name = "OddCheckBox";
            this.OddCheckBox.Size = new System.Drawing.Size(49, 19);
            this.OddCheckBox.TabIndex = 1;
            this.OddCheckBox.Text = "Odd";
            this.OddCheckBox.UseVisualStyleBackColor = true;
            // 
            // EvenCheckBox
            // 
            this.EvenCheckBox.AutoSize = true;
            this.EvenCheckBox.Location = new System.Drawing.Point(45, 32);
            this.EvenCheckBox.Name = "EvenCheckBox";
            this.EvenCheckBox.Size = new System.Drawing.Size(53, 19);
            this.EvenCheckBox.TabIndex = 1;
            this.EvenCheckBox.Text = "Even";
            this.EvenCheckBox.UseVisualStyleBackColor = true;
            // 
            // showCheckBoxButton
            // 
            this.showCheckBoxButton.Location = new System.Drawing.Point(91, 87);
            this.showCheckBoxButton.Name = "showCheckBoxButton";
            this.showCheckBoxButton.Size = new System.Drawing.Size(75, 23);
            this.showCheckBoxButton.TabIndex = 0;
            this.showCheckBoxButton.Text = "Show";
            this.showCheckBoxButton.UseVisualStyleBackColor = true;
            this.showCheckBoxButton.Click += new System.EventHandler(this.showCheckBoxButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(390, 221);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 0;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 460);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.CheckBoxGroupBox);
            this.Controls.Add(this.RadioButtonGroupBox);
            this.Controls.Add(this.ComboBoxGroupBox);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainUI";
            this.Text = "Different Controls App";
            this.ComboBoxGroupBox.ResumeLayout(false);
            this.RadioButtonGroupBox.ResumeLayout(false);
            this.RadioButtonGroupBox.PerformLayout();
            this.CheckBoxGroupBox.ResumeLayout(false);
            this.CheckBoxGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComboBoxGroupBox;
        private System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.Button showComboBoxButton;
        private System.Windows.Forms.GroupBox RadioButtonGroupBox;
        private System.Windows.Forms.RadioButton OddRadioButton;
        private System.Windows.Forms.RadioButton EvenRadioButton;
        private System.Windows.Forms.Button showRadioButtonButton;
        private System.Windows.Forms.GroupBox CheckBoxGroupBox;
        private System.Windows.Forms.CheckBox OddCheckBox;
        private System.Windows.Forms.CheckBox EvenCheckBox;
        private System.Windows.Forms.Button showCheckBoxButton;
        private System.Windows.Forms.Button showAllButton;
    }
}

