namespace BSBD
{
    partial class changeMethodsForm
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
            this.methodsListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteMethodButton = new System.Windows.Forms.Button();
            this.malfunctionComboBox = new System.Windows.Forms.ComboBox();
            this.addMethodButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.methodsListBox);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 425);
            this.panel1.TabIndex = 0;
            // 
            // methodsListBox
            // 
            this.methodsListBox.FormattingEnabled = true;
            this.methodsListBox.Location = new System.Drawing.Point(3, 3);
            this.methodsListBox.Name = "methodsListBox";
            this.methodsListBox.Size = new System.Drawing.Size(250, 420);
            this.methodsListBox.TabIndex = 0;
            this.methodsListBox.SelectedIndexChanged += new System.EventHandler(this.methodsListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteMethodButton);
            this.panel2.Controls.Add(this.malfunctionComboBox);
            this.panel2.Controls.Add(this.addMethodButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(267, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 425);
            this.panel2.TabIndex = 1;
            // 
            // deleteMethodButton
            // 
            this.deleteMethodButton.Location = new System.Drawing.Point(5, 47);
            this.deleteMethodButton.Name = "deleteMethodButton";
            this.deleteMethodButton.Size = new System.Drawing.Size(200, 23);
            this.deleteMethodButton.TabIndex = 12;
            this.deleteMethodButton.Text = "Удалить";
            this.deleteMethodButton.UseVisualStyleBackColor = true;
            this.deleteMethodButton.Click += new System.EventHandler(this.deleteMethodButton_Click);
            // 
            // malfunctionComboBox
            // 
            this.malfunctionComboBox.FormattingEnabled = true;
            this.malfunctionComboBox.Location = new System.Drawing.Point(5, 20);
            this.malfunctionComboBox.Name = "malfunctionComboBox";
            this.malfunctionComboBox.Size = new System.Drawing.Size(200, 21);
            this.malfunctionComboBox.TabIndex = 11;
            // 
            // addMethodButton
            // 
            this.addMethodButton.Location = new System.Drawing.Point(5, 75);
            this.addMethodButton.Name = "addMethodButton";
            this.addMethodButton.Size = new System.Drawing.Size(200, 23);
            this.addMethodButton.TabIndex = 10;
            this.addMethodButton.Text = "Добавить метод";
            this.addMethodButton.UseVisualStyleBackColor = true;
            this.addMethodButton.Click += new System.EventHandler(this.addMethodButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Неисправность";
            // 
            // changeMethodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "changeMethodsForm";
            this.Text = "changeMethodsForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox methodsListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addMethodButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox malfunctionComboBox;
        private System.Windows.Forms.Button deleteMethodButton;
    }
}