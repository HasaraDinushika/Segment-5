namespace PresentationLayer
{
    partial class StudentRegistration
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
            this.idLabel = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.idValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(14, 29);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(67, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Student ID   ";
            // 
            // idText
            // 
            this.idText.AutoSize = true;
            this.idText.Location = new System.Drawing.Point(128, 30);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(0, 13);
            this.idText.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name           ";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(159, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(199, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(13, 107);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(71, 13);
            this.dobLabel.TabIndex = 4;
            this.dobLabel.Text = "Date Of Birth ";
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(13, 150);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(106, 13);
            this.gpaLabel.TabIndex = 5;
            this.gpaLabel.Text = "Grade Point Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Active";
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(159, 150);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(62, 20);
            this.gpaTextBox.TabIndex = 7;
            this.gpaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.gpaTextBox_Validating);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(159, 192);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.activeCheckBox.TabIndex = 8;
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(159, 101);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 9;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(271, 258);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 10;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(364, 258);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // idValueLabel
            // 
            this.idValueLabel.AutoSize = true;
            this.idValueLabel.Location = new System.Drawing.Point(159, 29);
            this.idValueLabel.Name = "idValueLabel";
            this.idValueLabel.Size = new System.Drawing.Size(0, 13);
            this.idValueLabel.TabIndex = 12;
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 293);
            this.Controls.Add(this.idValueLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.gpaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpaLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.idLabel);
            this.Name = "StudentRegistration";
            this.ShowIcon = false;
            this.Text = "Student Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label idValueLabel;
    }
}