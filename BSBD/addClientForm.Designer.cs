namespace BSBD
{
    partial class addClientForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.birthDayLabel = new System.Windows.Forms.Label();
            this.birthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneNumberRichTextBox = new System.Windows.Forms.RichTextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.fullNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.addressRichTextBox);
            this.panel1.Controls.Add(this.birthDayLabel);
            this.panel1.Controls.Add(this.birthDayDateTimePicker);
            this.panel1.Controls.Add(this.phoneNumberRichTextBox);
            this.panel1.Controls.Add(this.phoneNumberLabel);
            this.panel1.Controls.Add(this.fullNameRichTextBox);
            this.panel1.Controls.Add(this.fullNameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 370);
            this.panel1.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(17, 329);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 303);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(192, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ДОБАВИТЬ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.addressLabel.Location = new System.Drawing.Point(65, 136);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(69, 20);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "АДРЕС";
            // 
            // addressRichTextBox
            // 
            this.addressRichTextBox.Location = new System.Drawing.Point(3, 159);
            this.addressRichTextBox.Name = "addressRichTextBox";
            this.addressRichTextBox.Size = new System.Drawing.Size(194, 138);
            this.addressRichTextBox.TabIndex = 3;
            this.addressRichTextBox.Text = "";
            // 
            // birthDayLabel
            // 
            this.birthDayLabel.AutoSize = true;
            this.birthDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.birthDayLabel.Location = new System.Drawing.Point(17, 90);
            this.birthDayLabel.Name = "birthDayLabel";
            this.birthDayLabel.Size = new System.Drawing.Size(161, 20);
            this.birthDayLabel.TabIndex = 5;
            this.birthDayLabel.Text = "ДАТА РОЖДЕНИЯ";
            // 
            // birthDayDateTimePicker
            // 
            this.birthDayDateTimePicker.Location = new System.Drawing.Point(3, 113);
            this.birthDayDateTimePicker.Name = "birthDayDateTimePicker";
            this.birthDayDateTimePicker.Size = new System.Drawing.Size(192, 20);
            this.birthDayDateTimePicker.TabIndex = 2;
            // 
            // phoneNumberRichTextBox
            // 
            this.phoneNumberRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.phoneNumberRichTextBox.Location = new System.Drawing.Point(15, 69);
            this.phoneNumberRichTextBox.Name = "phoneNumberRichTextBox";
            this.phoneNumberRichTextBox.Size = new System.Drawing.Size(170, 20);
            this.phoneNumberRichTextBox.TabIndex = 1;
            this.phoneNumberRichTextBox.Text = "";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.phoneNumberLabel.Location = new System.Drawing.Point(11, 46);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(177, 20);
            this.phoneNumberLabel.TabIndex = 2;
            this.phoneNumberLabel.Text = "НОМЕР ТЕЛЕФОНА";
            // 
            // fullNameRichTextBox
            // 
            this.fullNameRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fullNameRichTextBox.Location = new System.Drawing.Point(15, 23);
            this.fullNameRichTextBox.Name = "fullNameRichTextBox";
            this.fullNameRichTextBox.Size = new System.Drawing.Size(170, 20);
            this.fullNameRichTextBox.TabIndex = 0;
            this.fullNameRichTextBox.Text = "";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.fullNameLabel.Location = new System.Drawing.Point(76, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(49, 20);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "ФИО";
            // 
            // addClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 394);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addClientForm";
            this.Text = "addClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox fullNameRichTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.DateTimePicker birthDayDateTimePicker;
        private System.Windows.Forms.RichTextBox phoneNumberRichTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label birthDayLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.RichTextBox addressRichTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label errorLabel;
    }
}