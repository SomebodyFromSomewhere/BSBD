using MySqlX.XDevAPI;
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
    public partial class mainWindowForm : Form
    {
        private DataTable repairWorks;
        private DataTable masters;
        private DataTable repairMethods;

        public mainWindowForm()
        {
            InitializeComponent();
            panel3.Hide();
            update();
        }

        public void update(int selectedIndex = -1)
        {

            repairWorks = main.dataBase.GetRecords("repair_works");
            orderListBox.Items.Clear();
            foreach (DataRow row in repairWorks.Rows)
            {
                uint product_id = row.Field<uint>("order_id");
                orderListBox.Items.Add("Заказ номер: " + product_id.ToString());
            }

            masters = main.dataBase.GetRecords("masters");

            repairMethods = main.dataBase.GetRecords("repair_methods");

            deviceComboBox.Items.Clear();
            foreach (DataRow device in repairMethods.Rows)
            {
                var deviceName = device.Field<string>("device_name");
                if (!deviceComboBox.Items.Contains(deviceName))
                {
                    deviceComboBox.Items.Add(deviceName);
                }
            }
            orderListBox.SelectedIndex = selectedIndex;
        }

        private void orderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderListBox.SelectedIndex == -1)
            {
                panel3.Hide();
                return;
            }

            string orderId = repairWorks.Rows[orderListBox.SelectedIndex].Field<uint>("order_id").ToString();
            DataRow repairWork = main.dataBase.GetRecord("repair_works", "order_id", orderId);
            DataRow order = main.dataBase.GetRecord("orders", "id", orderId);

            deviceComboBox.SelectedItem = repairWork.Field<string>("product_name");
            malfunctionComboBox.SelectedItem = repairWork.Field<string>("malfunction");

            orderClientCommentRichTextBox.Text = order.Field<string>("client_comment");
            repairCostRichTextBox.Text = order.Field<int>("order_price").ToString();

            masterComboBox.Items.Clear();
            foreach (DataRow master in masters.Rows)
            {
                if (master.Field<uint>("id") == repairWork.Field<uint>("master_id"))
                {
                    masterComboBox.Items.Add(master.Field<string>("full_name"));
                    masterComboBox.SelectedIndex = masterComboBox.Items.Count - 1;
                }
                else
                {
                    masterComboBox.Items.Add(master.Field<string>("full_name"));
                }
            }

            repairDurationDateTimePicker.Value = order.Field<DateTime>("order_completion_period");
            panel3.Show();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            addOrderForm orderForm = new addOrderForm();
            orderForm.ShowDialog();
            update();
        }

        private void devButton_Click(object sender, EventArgs e)
        {
            addMasterForm masterForm = new addMasterForm();
            masterForm.ShowDialog();
            update(orderListBox.SelectedIndex);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string comment = orderClientCommentRichTextBox.Text;

            if (deviceComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Выберите устройство";
                return;
            }

            if (malfunctionComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Выберите неисправность";
                return;
            }

            int cost;
            if (repairCostRichTextBox.Text == String.Empty || !int.TryParse(repairCostRichTextBox.Text, out cost))
            {
                errorLabel.Text = "Введите стоимость";
                return;
            }

            if (repairDurationDateTimePicker.Value == DateTime.Now)
            {
                errorLabel.Text = "Выберите дату окончания ремонта";
                return;
            }

            if (orderClientCommentRichTextBox.Text == "Комментарий клиента")
            {
                comment = string.Empty;
            }

            errorLabel.Text = String.Empty;


            string creationTime = DateTime.Now.GetDateTimeFormats()[51].Replace("Z", "");
            string completionTime = repairDurationDateTimePicker.Value.GetDateTimeFormats()[51].Replace("Z", "");
            string orderId = repairWorks.Rows[orderListBox.SelectedIndex].Field<uint>("order_id").ToString();
            string repairWorkId = repairWorks.Rows[orderListBox.SelectedIndex].Field<uint>("id").ToString();
            List<Tuple<string, string>> orderValues = new List<Tuple<string, string>> {
                new Tuple<string, string>("order_completion_period", completionTime),
                new Tuple<string, string>("order_price", cost.ToString()),
                new Tuple<string, string>("client_comment", comment)
            };
            List<Tuple<string, string>> orderWhereValues = new List<Tuple<string, string>> { new Tuple<string, string>("id", orderId) };

            main.dataBase.UpdateRecord("orders", orderValues, orderWhereValues);
            DataRow order = main.dataBase.GetRecord("orders", "id", orderId);
            if (order == null || order.ItemArray.Length == 0)
            {
                errorLabel.Text = "Возникла ошибка во время сохранения";
                update(orderListBox.SelectedIndex);
                return;
            }

            DataRow[] method = repairMethods.Select("device_name = '" + deviceComboBox.SelectedItem.ToString() + "' AND repair_type = '" + malfunctionComboBox.SelectedItem.ToString() + "'");
            if (method.Length == 0)
            {
                errorLabel.Text = "Возникла ошибка во время сохранения";
                update(orderListBox.SelectedIndex);
                return;
            }
            if (masterComboBox.SelectedIndex == -1)
            {
                masterComboBox.SelectedIndex = 0;
            }
            string masterId = masters.Rows[masterComboBox.SelectedIndex].Field<uint>("id").ToString();
            List<Tuple<string, string>> repairValues = new List<Tuple<string, string>> {
                new Tuple<string, string>("product_name", deviceComboBox.SelectedItem.ToString()),
                new Tuple<string, string>("malfunction", malfunctionComboBox.SelectedItem.ToString()),
                new Tuple<string, string>("master_id", masterId),
                new Tuple<string, string>("repair_method_id", method[0].Field<uint>("id").ToString())
            };

            List<Tuple<string, string>> repairWorkWhereValues = new List<Tuple<string, string>> { new Tuple<string, string>("id", repairWorkId) };
            main.dataBase.UpdateRecord("repair_works", repairValues, repairWorkWhereValues);

            update(orderListBox.SelectedIndex);
        }

        private void cost_update(object sender, EventArgs e)
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

            if (malfunctionComboBox.SelectedIndex == -1 || ((Control)sender).Name == deviceComboBox.Name)
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

            repairCostRichTextBox.Text = cost[0].Field<UInt32>("repair_cost").ToString();
            repairDurationDateTimePicker.Value = DateTime.Now.AddHours(cost[0].Field<UInt64>("repair_duration"));
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string orderId = repairWorks.Rows[orderListBox.SelectedIndex].Field<uint>("order_id").ToString();
            string repairWorkId = repairWorks.Rows[orderListBox.SelectedIndex].Field<uint>("id").ToString();

            List<Tuple<string, string>> orderWhereValues = new List<Tuple<string, string>> { new Tuple<string, string>("id", orderId) };
            List<Tuple<string, string>> repairWorkWhereValues = new List<Tuple<string, string>> { new Tuple<string, string>("id", repairWorkId) };
            main.dataBase.DeleteRecord("repair_works", repairWorkWhereValues);
            main.dataBase.DeleteRecord("orders", orderWhereValues);
            update();
            orderListBox_SelectedIndexChanged(orderListBox, EventArgs.Empty);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            update(orderListBox.SelectedIndex);
        }
    }
}
