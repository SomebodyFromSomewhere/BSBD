namespace BSBD
{
    partial class addOrderForm
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
            this.clientCommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.repairDurationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.addRepairTypeButton = new System.Windows.Forms.Button();
            this.malfunctionComboBox = new System.Windows.Forms.ComboBox();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.addClientButton = new System.Windows.Forms.Button();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.clientCommentRichTextBox);
            this.panel1.Controls.Add(this.repairDurationDateTimePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.costTextBox);
            this.panel1.Controls.Add(this.addRepairTypeButton);
            this.panel1.Controls.Add(this.malfunctionComboBox);
            this.panel1.Controls.Add(this.deviceComboBox);
            this.panel1.Controls.Add(this.addClientButton);
            this.panel1.Controls.Add(this.clientComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 455);
            this.panel1.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(15, 429);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 11;
            // 
            // clientCommentRichTextBox
            // 
            this.clientCommentRichTextBox.Location = new System.Drawing.Point(15, 186);
            this.clientCommentRichTextBox.Name = "clientCommentRichTextBox";
            this.clientCommentRichTextBox.Size = new System.Drawing.Size(366, 205);
            this.clientCommentRichTextBox.TabIndex = 7;
            this.clientCommentRichTextBox.Text = "Комментарий клиента";
            // 
            // repairDurationDateTimePicker
            // 
            this.repairDurationDateTimePicker.Location = new System.Drawing.Point(15, 160);
            this.repairDurationDateTimePicker.Name = "repairDurationDateTimePicker";
            this.repairDurationDateTimePicker.Size = new System.Drawing.Size(366, 20);
            this.repairDurationDateTimePicker.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Цена";
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(15, 397);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(366, 25);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(61, 124);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(200, 20);
            this.costTextBox.TabIndex = 5;
            // 
            // addRepairTypeButton
            // 
            this.addRepairTypeButton.Location = new System.Drawing.Point(231, 54);
            this.addRepairTypeButton.Name = "addRepairTypeButton";
            this.addRepairTypeButton.Size = new System.Drawing.Size(150, 21);
            this.addRepairTypeButton.TabIndex = 3;
            this.addRepairTypeButton.Text = "Добавить неисправность";
            this.addRepairTypeButton.UseVisualStyleBackColor = true;
            this.addRepairTypeButton.Click += new System.EventHandler(this.addRepairTypeButton_Click);
            // 
            // malfunctionComboBox
            // 
            this.malfunctionComboBox.FormattingEnabled = true;
            this.malfunctionComboBox.Location = new System.Drawing.Point(15, 88);
            this.malfunctionComboBox.Name = "malfunctionComboBox";
            this.malfunctionComboBox.Size = new System.Drawing.Size(200, 21);
            this.malfunctionComboBox.TabIndex = 4;
            this.malfunctionComboBox.Text = "Неисправность";
            this.malfunctionComboBox.SelectedIndexChanged += new System.EventHandler(this.costUpdate);
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(15, 54);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(200, 21);
            this.deviceComboBox.TabIndex = 2;
            this.deviceComboBox.Text = "Устройство";
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.costUpdate);
            this.deviceComboBox.SelectedValueChanged += new System.EventHandler(this.costUpdate);
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(231, 20);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(150, 21);
            this.addClientButton.TabIndex = 1;
            this.addClientButton.Text = "Добавить клиента";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(15, 20);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(200, 21);
            this.clientComboBox.TabIndex = 0;
            this.clientComboBox.Text = "ФИО Клиента";
            // 
            // addOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 479);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addOrderForm";
            this.Text = "addOrderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Button addRepairTypeButton;
        private System.Windows.Forms.ComboBox malfunctionComboBox;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker repairDurationDateTimePicker;
        private System.Windows.Forms.RichTextBox clientCommentRichTextBox;
        private System.Windows.Forms.Label errorLabel;
    }
}