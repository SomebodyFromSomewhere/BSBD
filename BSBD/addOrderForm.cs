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
    public partial class addOrderForm : Form
    {
        private DataTable clients;
        private DataTable repairMethods;

        public addOrderForm()
        {
            InitializeComponent();
            update();
        }

        public void update()
        {
            clients = main.dataBase.GetRecords("clients");
            repairMethods = main.dataBase.GetRecords("repair_methods");
            clientComboBox.Items.Clear();
            foreach (DataRow client in clients.Rows)
            {
                clientComboBox.Items.Add(client.Field<string>("full_name"));
            }

            deviceComboBox.Items.Clear();
            foreach (DataRow device in repairMethods.Rows)
            {
                var deviceName = device.Field<string>("device_name");
                if (!deviceComboBox.Items.Contains(deviceName))
                {
                    deviceComboBox.Items.Add(deviceName);
                }
            }
        }

        private void costUpdate(object sender, EventArgs e)
        {
            if (deviceComboBox.SelectedIndex == -1)
            {
                malfunctionComboBox.Items.Clear();
                malfunctionComboBox.SelectedIndex = -1;
                malfunctionComboBox.SelectedItem = null;
                malfunctionComboBox.SelectedValue = "";
                malfunctionComboBox.Text = "";
                return;
            }



            if (malfunctionComboBox.SelectedIndex == -1 || deviceComboBox.Name == ((Control)sender).Name)
            {
                DataRow[] malfuntions = repairMethods.Select("device_name = '" + deviceComboBox.Text + "'");
                malfunctionComboBox.Items.Clear();
                malfunctionComboBox.SelectedIndex = -1;
                malfunctionComboBox.SelectedItem = null;
                malfunctionComboBox.SelectedValue = "";
                malfunctionComboBox.Text = "";
                foreach (var malfunction in malfuntions)
                {
                    malfunctionComboBox.Items.Add(malfunction.Field<string>("repair_type"));
                }
                return;
            }

            DataRow[] cost = repairMethods.Select("device_name = '" + deviceComboBox.SelectedItem.ToString() + "' AND repair_type = '" + malfunctionComboBox.SelectedItem.ToString() + "'");
            if (cost.Length == 0)
            {
                return;
            }

            costTextBox.Text = cost[0].Field<UInt32>("repair_cost").ToString();
            repairDurationDateTimePicker.Value = DateTime.Now.AddHours(cost[0].Field<UInt64>("repair_duration"));
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            addClientForm clientForm = new addClientForm();
            clientForm.ShowDialog();
            update();
        }

        private void addMasterButton_Click(object sender, EventArgs e)
        {
            addMasterForm masterForm = new addMasterForm();
            masterForm.ShowDialog();
        }

        private void addRepairTypeButton_Click(object sender, EventArgs e)
        {
            addRepairMethodForm repairMethodForm = new addRepairMethodForm();
            repairMethodForm.ShowDialog();
            update();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int cost;
            DataRow[] client;
            string clientId;
            string comment = clientCommentRichTextBox.Text.Replace("'", "\'");
            if (clientComboBox.SelectedIndex == -1)
            {
                foreach (var item in clientComboBox.Items)
                {
                    if (item.ToString() == clientComboBox.Text)
                    {
                        clientComboBox.SelectedItem = item;
                        break;
                    }
                }

                if (clientComboBox.SelectedItem == null)
                {
                    errorLabel.Text = "Выберите клиента";
                    return;
                }
            }

            if (deviceComboBox.SelectedIndex == -1)
            {
                foreach (var item in deviceComboBox.Items)
                {
                    if (item.ToString() == deviceComboBox.Text)
                    {
                        deviceComboBox.SelectedItem = item;
                        break;
                    }
                }

                if (deviceComboBox.SelectedItem == null)
                {
                    errorLabel.Text = "Выберите устройство";
                    return;
                }
            }

            if (malfunctionComboBox.SelectedIndex == -1)
            {
                foreach (var item in malfunctionComboBox.Items)
                {
                    if (item.ToString() == malfunctionComboBox.Text)
                    {
                        malfunctionComboBox.SelectedItem = item;
                        break;
                    }
                }

                if (malfunctionComboBox.SelectedItem == null)
                {
                    errorLabel.Text = "Выберите неисправность";
                    return;
                }
            }

            if (costTextBox.Text == String.Empty || !int.TryParse(costTextBox.Text, out cost))
            {
                errorLabel.Text = "Введите стоимость";
                return;
            }

            if (repairDurationDateTimePicker.Value == DateTime.Now)
            {
                errorLabel.Text = "Выберите дату окончания ремонта";
                return;
            }

            if (clientCommentRichTextBox.Text == "Комментарий клиента")
            {
                comment = string.Empty;
            }

            errorLabel.Text = String.Empty;

            client = clients.Select("full_name = '" + clientComboBox.SelectedItem.ToString() + "'");
            if (client.Length == 0)
            {
                errorLabel.Text = "Возникла ошибка во время сохранения";
                update();
                return;
            }

            string creationTime = DateTime.Now.GetDateTimeFormats()[51].Replace("Z", "");
            string completionTime = repairDurationDateTimePicker.Value.GetDateTimeFormats()[51].Replace("Z", "");
            clientId = client[0].Field<uint>("id").ToString();
            List<Tuple<string, string>> orderValues = new List<Tuple<string, string>> {
                new Tuple<string, string>("client_id", clientId),
                new Tuple<string, string>("order_creation_time", creationTime),
                new Tuple<string, string>("order_completion_period", completionTime),
                new Tuple<string, string>("order_price", cost.ToString()),
                new Tuple<string, string>("client_comment", comment)
            };

            main.dataBase.InsertRecord("orders", orderValues);
            DataRow order = main.dataBase.GetRecord("orders", "order_creation_time", creationTime);
            if (order.ItemArray.Length == 0)
            {
                errorLabel.Text = "Возникла ошибка во время сохранения";
                update();
                return;
            }

            uint orderId = order.Field<uint>("id");
            DataRow[] method = repairMethods.Select("device_name = '" + deviceComboBox.SelectedItem.ToString() + "' AND repair_type = '" + malfunctionComboBox.SelectedItem.ToString() + "'");
            if (method.Length == 0)
            {
                errorLabel.Text = "Возникла ошибка во время сохранения";
                update();
                return;
            }

            List<Tuple<string, string>> repairValues = new List<Tuple<string, string>> {
                new Tuple<string, string>("product_name", deviceComboBox.SelectedItem.ToString()),
                new Tuple<string, string>("malfunction", malfunctionComboBox.SelectedItem.ToString()),
                new Tuple<string, string>("master_id", "0"),
                new Tuple<string, string>("order_id", orderId.ToString()),
                new Tuple<string, string>("repair_method_id", method[0].Field<uint>("id").ToString())
            };
            main.dataBase.InsertRecord("repair_works", repairValues);
            this.Close();
        }
    }
}
