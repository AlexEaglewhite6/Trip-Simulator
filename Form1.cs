using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trip_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double Consumption = 1;
        Double Distance = 0;
        Double GasPrice = 0;
        Vehicle v;

        private void TankVolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            TankVolumeValueLabel.Text = TankVolumeTrackBar.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackInfoPanel.Visible= false;
        }

        private void TheWayBackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(TheWayBackCheckBox.Checked)
            {
                BackInfoPanel.Visible = true;
                
            }
            else
            {
                BackInfoPanel.Visible = false;
            }
        }

        private void CheckBoxChecker(object sender, EventArgs e)
        {
            if(Gas92CheckBox.Checked)
            {
                Gas95CheckBox.Enabled = false;
                Gas100CheckBox.Enabled = false;
                GasDieselCheckBox.Enabled = false;
                GasPrice = 49.76;
                return;
            }
            else
            {
                Gas95CheckBox.Enabled = true;
                Gas100CheckBox.Enabled = true;
                GasDieselCheckBox.Enabled = true;
                GasPrice = 0;
            }

            if (Gas95CheckBox.Checked)
            {
                Gas92CheckBox.Enabled = false;
                Gas100CheckBox.Enabled = false;
                GasDieselCheckBox.Enabled = false;
                GasPrice = 51.83;
                return;
            }
            else
            {
                Gas92CheckBox.Enabled = true;
                Gas100CheckBox.Enabled = true;
                GasDieselCheckBox.Enabled = true;
                GasPrice = 0;
            }

            if (Gas100CheckBox.Checked)
            {
                Gas92CheckBox.Enabled = false;
                Gas95CheckBox.Enabled = false;
                GasDieselCheckBox.Enabled = false;
                GasPrice = 64.35;
                return;
            }
            else
            {
                Gas92CheckBox.Enabled = true;
                Gas95CheckBox.Enabled = true;
                GasDieselCheckBox.Enabled = true;
                GasPrice = 0;
            }

            if (GasDieselCheckBox.Checked)
            {
                Gas92CheckBox.Enabled = false;
                Gas95CheckBox.Enabled = false;
                Gas100CheckBox.Enabled = false;
                GasPrice = 53.39;
                return;
            }
            else
            {
                Gas92CheckBox.Enabled = true;
                Gas95CheckBox.Enabled = true;
                Gas100CheckBox.Enabled = true;
                GasPrice = 0;
            }
        }

        private void ConsumptionValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!Double.TryParse(ConsumptionValueTextBox.Text, out Consumption))
            {
                CalculateButton.Enabled = false;
            }
            else
            {
                CalculateButton.Enabled = true;
            }
        }

        private void DistanceValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(DistanceValueTextBox.Text, out Distance))
            {
                CalculateButton.Enabled = false;
            }
            else
            {
                CalculateButton.Enabled = true;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                v = new Vehicle(TankVolumeTrackBar.Value, Consumption);
                double[] info = v.GetOneWayTripInfo(Distance, GasPrice);
                PriceLabel.Text = $"Стоимость поездки: {info[0]} руб.";
                RefillLabel.Text = $"Количество заправок: {info[1]}";
                double[] backinfo = v.GetOneWayTripInfo(Distance, GasPrice);
                BackPriceLabel.Text = $"Стоимость поездки: {backinfo[0]} руб.";
                BackRefillLabel.Text = $"Количество заправок: {backinfo[1]}";
                AllPriceLabel.Text = $"Общая стоимость поездки: {info[0] + backinfo[0]} руб.";
                AllRefillLabel.Text = $"Количество заправок: {info[1] + backinfo[1]}";
            }
            catch
            {
                MessageBox.Show("Вы ввели слишком большие числа!\nВведите числа поменьше!", "Ошибка", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            
        }
    }
}
