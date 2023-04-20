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
    public partial class changeMethodsForm : Form
    {
        private DataTable methods;

        public changeMethodsForm()
        {
            InitializeComponent();
            update();
        }
        public void update(int index = -1)
        {
            methodsListBox.Items.Clear();
            methods = main.dataBase.GetRecords("repair_methods");
            foreach (DataRow item in methods.Rows)
            {
                string deviceName = item.Field<string>("device_name");
                if (!methodsListBox.Items.Contains(deviceName))
                {
                    methodsListBox.Items.Add(deviceName);
                }
            }

            methodsListBox.SelectedIndex = index;
        }

        private void methodsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (methodsListBox.SelectedIndex == -1)
            {
                return;
            }
            var method = methods.Select("device_name = '" + methodsListBox.SelectedItem.ToString() + "'");
            malfunctionComboBox.Items.Clear();
            foreach (var item in method)
            {
                malfunctionComboBox.Items.Add(item.Field<string>("repair_type"));
            }
        }

        private void addMethodButton_Click(object sender, EventArgs e)
        {
            addRepairMethodForm methodForm = new addRepairMethodForm();
            methodForm.ShowDialog();
            update(methodsListBox.SelectedIndex);
        }

        private void deleteMethodButton_Click(object sender, EventArgs e)
        {
            if (methodsListBox.SelectedIndex == -1 || malfunctionComboBox.SelectedIndex == -1)
            {
                return;
            }

            DataRow[] method = methods.Select("device_name = '" + methodsListBox.SelectedItem.ToString() +
                "' AND repair_type = '" + malfunctionComboBox.SelectedItem.ToString() + "'");
            List<Tuple<string, string>> values = new List<Tuple<string, string>> {
                new Tuple<string, string>("id", method[0].Field<UInt32>("id").ToString())
            };

            List<Tuple<string, string>> updateValues = new List<Tuple<string, string>> {
                new Tuple<string, string>("malfunction", "")
            };

            List<Tuple<string, string>> whereValues = new List<Tuple<string, string>> {
                new Tuple<string, string>("malfunction", method[0].Field<string>("repair_type").ToString())
            };

            main.dataBase.UpdateRecord("repair_works", updateValues, updateValues);
            main.dataBase.DeleteRecord("repair_methods", values);
            update(methodsListBox.SelectedIndex);
        }
    }
}
