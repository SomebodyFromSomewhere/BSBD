using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD
{
    public partial class addClientForm : Form
    {
        public addClientForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameRichTextBox.Text;
            string phoneNumber = phoneNumberRichTextBox.Text;
            string address = addressRichTextBox.Text;
            DateTime birthDay = birthDayDateTimePicker.Value;

            if (fullName == string.Empty)
            {
                errorLabel.Text = "НЕОБХОДИМО ВВЕСТИ ФИО";
                return;
            }

            if (phoneNumber == string.Empty)
            {
                errorLabel.Text = "ВВЕДИТЕ НОМЕР ТЕЛЕФОНА";
                return;
            }

            if (address == string.Empty)
            {
                errorLabel.Text = "НЕОБХОДИМО ВВЕСТИ АДРЕСС";
                return;
            }

            if (birthDay.Date == DateTime.Today)
            {
                errorLabel.Text = "ВВЕДИТЕ ДАТУ РОЖДЕНИЯ";
                return;
            }
            errorLabel.Text = string.Empty;
            List<Tuple<string, string>> values = new List<Tuple<string, string>> {
                new Tuple<string, string>("full_name", fullName),
                new Tuple<string, string>("phone_number", phoneNumber),
                new Tuple<string, string>("birthday", "STR_TO_DATE(\"" + birthDay.Date.ToString() + "\", \"%d.%m.%Y %T\")"),
                new Tuple<string, string>("address", address),
            };
            main.dataBase.InsertRecord("clients", values);
            this.Close();
        }
    }
}
