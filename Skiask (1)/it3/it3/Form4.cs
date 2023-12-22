using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it3
{
    public partial class skipasses : Form
    {
        public skipasses()
        {
            InitializeComponent();
        }

        private void daysamount_Leave(object sender, EventArgs e)
        {
            if (daysamount.Text == "")
            {
                daysamount.Text = "Введіть кількість днів";
                daysamount.ForeColor = Color.Gray;
            }
        }

        private void daysamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void daysamount_Enter(object sender, EventArgs e)
        {
            if (daysamount.Text == "Введіть кількість днів")
            {
                daysamount.Text = "";
                daysamount.ForeColor = Color.Black;
            }
        }
        private void enter_Click(object sender, EventArgs e)
        {
            string daysAmountValue = daysamount.Text;

            if (string.IsNullOrWhiteSpace(daysAmountValue) || daysAmountValue == "Введіть кількість днів")
            {
                MessageBox.Show("Введіть кількість днів");
                daysamount.Focus();
                return;
            }

            if (float.TryParse(daysAmountValue, out float numericDaysAmount))
            {
                if (numericDaysAmount < 0 || numericDaysAmount > 14)
                {
                    MessageBox.Show("Введіть коректне числове значення для кількості днів (від 0 до 14).");
                    daysamount.Focus();
                    return;
                }

                MessageBox.Show($"Кількість днів на яку ви обрали абонемент: {numericDaysAmount}. \nЯкщо все вірно, то натисніть кнопку Замовити.");
            }
            else
            {
                MessageBox.Show("Введіть коректне числове значення для кількості днів.");
                daysamount.Focus();
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mkorder_Click(object sender, EventArgs e)
        {
            string daysAmountValue = daysamount.Text;

            if (string.IsNullOrWhiteSpace(daysAmountValue) || daysAmountValue == "Введіть кількість днів")
            {
                MessageBox.Show("Введіть кількість днів");
                daysamount.Focus();
                return;
            }

            if (float.TryParse(daysAmountValue, out float numericDaysAmount))
            {
                if (numericDaysAmount < 0 || numericDaysAmount > 14)
                {
                    MessageBox.Show("Введіть коректне числове значення для кількості днів (від 0 до 14).");
                    daysamount.Focus();
                    return;
                }

                MessageBox.Show("Дякую за замовлення, підійдіть до пункну видачі, щоб забрати спорядження та абонемент.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Введіть коректне числове значення для кількості днів.");
                daysamount.Focus();
            }
        }
    }

}
