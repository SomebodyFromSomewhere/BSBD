namespace BSBD
{
    partial class addRepairMethodForm
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
            this.repairCostRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.repairDurationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.repairTypeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deviceTypeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.deviceNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.repairCostRichTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.repairDurationRichTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.repairTypeRichTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.deviceTypeRichTextBox);
            this.panel1.Controls.Add(this.phoneNumberLabel);
            this.panel1.Controls.Add(this.deviceNameRichTextBox);
            this.panel1.Controls.Add(this.fullNameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 285);
            this.panel1.TabIndex = 1;
            // 
            // repairCostRichTextBox
            // 
            this.repairCostRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.repairCostRichTextBox.Location = new System.Drawing.Point(14, 161);
            this.repairCostRichTextBox.Name = "repairCostRichTextBox";
            this.repairCostRichTextBox.Size = new System.Drawing.Size(170, 20);
            this.repairCostRichTextBox.TabIndex = 3;
            this.repairCostRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Стоимость ремонта";
            // 
            // repairDurationRichTextBox
            // 
            this.repairDurationRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.repairDurationRichTextBox.Location = new System.Drawing.Point(15, 207);
            this.repairDurationRichTextBox.Name = "repairDurationRichTextBox";
            this.repairDurationRichTextBox.Size = new System.Drawing.Size(170, 20);
            this.repairDurationRichTextBox.TabIndex = 4;
            this.repairDurationRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(18, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Период ремонта (часы)";
            // 
            // repairTypeRichTextBox
            // 
            this.repairTypeRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.repairTypeRichTextBox.Location = new System.Drawing.Point(15, 115);
            this.repairTypeRichTextBox.Name = "repairTypeRichTextBox";
            this.repairTypeRichTextBox.Size = new System.Drawing.Size(170, 20);
            this.repairTypeRichTextBox.TabIndex = 2;
            this.repairTypeRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Тип ремонта";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(18, 259);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 233);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(192, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "ДОБАВИТЬ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deviceTypeRichTextBox
            // 
            this.deviceTypeRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deviceTypeRichTextBox.Location = new System.Drawing.Point(15, 69);
            this.deviceTypeRichTextBox.Name = "deviceTypeRichTextBox";
            this.deviceTypeRichTextBox.Size = new System.Drawing.Size(170, 20);
            this.deviceTypeRichTextBox.TabIndex = 1;
            this.deviceTypeRichTextBox.Text = "";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.phoneNumberLabel.Location = new System.Drawing.Point(42, 46);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(111, 20);
            this.phoneNumberLabel.TabIndex = 2;
            this.phoneNumberLabel.Text = "Тип техники";
            // 
            // deviceNameRichTextBox
            // 
            this.deviceNameRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deviceNameRichTextBox.Location = new System.Drawing.Point(15, 23);
            this.deviceNameRichTextBox.Name = "deviceNameRichTextBox";
            this.deviceNameRichTextBox.Size = new System.Drawing.Size(170, 20);
            this.deviceNameRichTextBox.TabIndex = 0;
            this.deviceNameRichTextBox.Text = "";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.fullNameLabel.Location = new System.Drawing.Point(17, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(163, 20);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Название техники";
            // 
            // addRepairMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 306);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addRepairMethodForm";
            this.Text = "addRepairMethod";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox deviceTypeRichTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.RichTextBox deviceNameRichTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.RichTextBox repairDurationRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox repairTypeRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox repairCostRichTextBox;
        private System.Windows.Forms.Label label3;
    }
}