namespace BSBD
{
    partial class mainWindowForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.devButton = new System.Windows.Forms.Button();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.malfunctionComboBox = new System.Windows.Forms.ComboBox();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.repairDurationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.masterComboBox = new System.Windows.Forms.ComboBox();
            this.orderClientCommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.repairCostRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.devButton);
            this.panel1.Controls.Add(this.addOrderButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 30);
            this.panel1.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(801, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // devButton
            // 
            this.devButton.Location = new System.Drawing.Point(670, 3);
            this.devButton.Name = "devButton";
            this.devButton.Size = new System.Drawing.Size(125, 23);
            this.devButton.TabIndex = 10;
            this.devButton.Text = "DEV";
            this.devButton.UseVisualStyleBackColor = true;
            this.devButton.Click += new System.EventHandler(this.devButton_Click);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(15, 3);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(125, 23);
            this.addOrderButton.TabIndex = 0;
            this.addOrderButton.Text = "Добавить заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.orderListBox);
            this.panel2.Location = new System.Drawing.Point(12, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 499);
            this.panel2.TabIndex = 1;
            // 
            // orderListBox
            // 
            this.orderListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(15, 14);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(498, 470);
            this.orderListBox.TabIndex = 1;
            this.orderListBox.SelectedIndexChanged += new System.EventHandler(this.orderListBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.errorLabel);
            this.panel3.Controls.Add(this.malfunctionComboBox);
            this.panel3.Controls.Add(this.deviceComboBox);
            this.panel3.Controls.Add(this.repairDurationDateTimePicker);
            this.panel3.Controls.Add(this.deleteButton);
            this.panel3.Controls.Add(this.saveButton);
            this.panel3.Controls.Add(this.masterComboBox);
            this.panel3.Controls.Add(this.orderClientCommentRichTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.repairCostRichTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(545, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 498);
            this.panel3.TabIndex = 2;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(7, 369);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 12;
            // 
            // malfunctionComboBox
            // 
            this.malfunctionComboBox.FormattingEnabled = true;
            this.malfunctionComboBox.Location = new System.Drawing.Point(10, 79);
            this.malfunctionComboBox.Name = "malfunctionComboBox";
            this.malfunctionComboBox.Size = new System.Drawing.Size(383, 21);
            this.malfunctionComboBox.TabIndex = 11;
            this.malfunctionComboBox.Text = "Неисправность";
            this.malfunctionComboBox.SelectedIndexChanged += new System.EventHandler(this.cost_update);
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(10, 30);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(383, 21);
            this.deviceComboBox.TabIndex = 10;
            this.deviceComboBox.Text = "Устройство";
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.cost_update);
            // 
            // repairDurationDateTimePicker
            // 
            this.repairDurationDateTimePicker.Location = new System.Drawing.Point(137, 300);
            this.repairDurationDateTimePicker.Name = "repairDurationDateTimePicker";
            this.repairDurationDateTimePicker.Size = new System.Drawing.Size(256, 20);
            this.repairDurationDateTimePicker.TabIndex = 7;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(10, 341);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(175, 25);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(218, 341);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(175, 25);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // masterComboBox
            // 
            this.masterComboBox.FormattingEnabled = true;
            this.masterComboBox.Location = new System.Drawing.Point(10, 300);
            this.masterComboBox.Name = "masterComboBox";
            this.masterComboBox.Size = new System.Drawing.Size(121, 21);
            this.masterComboBox.TabIndex = 6;
            // 
            // orderClientCommentRichTextBox
            // 
            this.orderClientCommentRichTextBox.Location = new System.Drawing.Point(10, 179);
            this.orderClientCommentRichTextBox.Name = "orderClientCommentRichTextBox";
            this.orderClientCommentRichTextBox.Size = new System.Drawing.Size(383, 88);
            this.orderClientCommentRichTextBox.TabIndex = 5;
            this.orderClientCommentRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Коментарий клиента";
            // 
            // repairCostRichTextBox
            // 
            this.repairCostRichTextBox.Location = new System.Drawing.Point(10, 129);
            this.repairCostRichTextBox.Name = "repairCostRichTextBox";
            this.repairCostRichTextBox.Size = new System.Drawing.Size(383, 25);
            this.repairCostRichTextBox.TabIndex = 4;
            this.repairCostRichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Назначенный мастер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Неисправность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название товара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Дата завершения заказа";
            // 
            // mainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainWindowForm";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button devButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox masterComboBox;
        private System.Windows.Forms.RichTextBox orderClientCommentRichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox repairCostRichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DateTimePicker repairDurationDateTimePicker;
        private System.Windows.Forms.ComboBox malfunctionComboBox;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label6;
    }
}

