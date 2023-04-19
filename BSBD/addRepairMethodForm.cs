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
    public partial class addRepairMethodForm : Form
    {
        public addRepairMethodForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string deviceName = deviceNameRichTextBox.Text;
            string deviceType = deviceTypeRichTextBox.Text;
            string repairType = repairTypeRichTextBox.Text;
            int repairCost;
            bool repairCostConversionResult = int.TryParse(repairCostRichTextBox.Text, out repairCost);
            int repairDuration;
            bool repairDurationConversionResult = int.TryParse(repairDurationRichTextBox.Text, out repairDuration);

            if (deviceName == string.Empty)
            {
                errorLabel.Text = "ВВЕДИТЕ ИМЯ УСТРОЙСТВА";
                return;
            }

            if (deviceType == string.Empty)
            {
                errorLabel.Text = "ВВЕДИТЕ ТИП УСТРОЙСТВА";
                return;
            }

            if (repairType == string.Empty)
            {
                errorLabel.Text = "ВВЕДИТЕ ТИП РЕМОНТА";
                return;
            }

            if (!repairCostConversionResult)
            {
                errorLabel.Text = "ВВЕДИТЕ СТОИМОСТЬ РЕМОНТА";
                return;
            }

            if (!repairDurationConversionResult)
            {
                errorLabel.Text = "ВВЕДИТЕ ДЛИТЕЛЬНОСТЬ РЕМОНТА";
                return;
            }

            errorLabel.Text = string.Empty;
            List<Tuple<string, string>> values = new List<Tuple<string, string>> {
                new Tuple<string, string>("device_name", deviceName),
                new Tuple<string, string>("device_type", deviceType),
                new Tuple<string, string>("repair_type", repairType),
                new Tuple<string, string>("repair_cost", repairCost.ToString()),
                new Tuple<string, string>("repair_duration", repairDuration.ToString())
            };
            main.dataBase.InsertRecord("repair_methods", values);
            this.Close();
        }

    }
}
