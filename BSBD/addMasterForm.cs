using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD
{
    public partial class addMasterForm : Form
    {
        public addMasterForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameRichTextBox.Text;
            int expirience;
            bool convertionResult = int.TryParse(expirienceRichTextBox.Text, out expirience);
            string post = postRichTextBox.Text;
            string phoneNumber = phoneNumberRichTextBox.Text;

            if (fullName == String.Empty)
            {
                errorLabel.Text = "ВВЕДИТЕ ФИО";
                return;
            }
            if (!convertionResult)
            {
                errorLabel.Text = "ВВЕДИТЕ ЧИСЛО";
                return;
            }
            if (post == String.Empty) 
            {
                errorLabel.Text = "ВВЕДИТЕ ДОЛЖНОСТЬ";
                return;
            }

            if (phoneNumber == String.Empty)
            {
                errorLabel.Text = "ВВЕДИТЕ НОМЕР ТЕЛЕФОНА";
                return;
            }

            errorLabel.Text = string.Empty;
            List<Tuple<string, string>> values = new List<Tuple<string, string>> {
                new Tuple<string, string>("full_name", fullName),
                new Tuple<string, string>("master_experience", expirience.ToString()),
                new Tuple<string, string>("post", post),
                new Tuple<string, string>("phone_number", phoneNumber)
            };
            main.dataBase.InsertRecord("masters", values);
            this.Close();
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
