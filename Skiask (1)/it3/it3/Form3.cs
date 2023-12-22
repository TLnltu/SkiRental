using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it3
{
    public partial class equipmentask : Form
    {
        public equipmentask()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            string heightValue = height.Text;

            if (string.IsNullOrWhiteSpace(heightValue) || heightValue == "Введіть зріст")
            {
                MessageBox.Show("Введіть коректний зріст.");
                height.Focus();
                return;
            }

            if (float.TryParse(heightValue, out float numericHeight))
            {
                if (numericHeight < 100 || numericHeight > 220)
                {
                    MessageBox.Show("Вибачте, але на даний момент є лижі лише для людей з ростом від 100 до 220 см.");
                    height.Focus();
                    return;
                }

                // Тепер перевіряємо розмір взуття
                string shoesizeValue = shoesize.Text;

                if (string.IsNullOrWhiteSpace(shoesizeValue) || shoesizeValue == "Введіть розмір взуття")
                {
                    MessageBox.Show("Введіть розмір взуття.");
                    shoesize.Focus();
                    return;
                }

                if (float.TryParse(shoesizeValue, out float numericShoeSize))
                {
                    if (numericShoeSize < 30 || numericShoeSize > 50)
                    {
                        MessageBox.Show("Вибачте, але на даний момент є лижі лише для людей з розміром взуття від 30 до 50.");
                        shoesize.Focus();
                        return;
                    }

                    this.Close();
                    skipasses f = new skipasses();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Введіть коректне числове значення для розміру взуття.");
                    shoesize.Focus();
                }
            }
            else
            {
                MessageBox.Show("Введіть коректне числове значення для зросту.");
                height.Focus();
            }
        }
        private void height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void height_Enter(object sender, EventArgs e)
        {
            if (height.Text == "Введіть зріст")
            {
                height.Text = "";
                height.ForeColor = Color.Black;
            }
        }

        private void height_Leave(object sender, EventArgs e)
        {
            if (height.Text == "")
            {
                height.Text = "Введіть зріст";
                height.ForeColor = Color.Gray;
            }
        }

        private void shoesize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void shoesize_Enter(object sender, EventArgs e)
        {
            if (shoesize.Text == "Введіть розмір взуття")
            {
                shoesize.Text = "";
                shoesize.ForeColor = Color.Black;
            }
        }

        private void shoesize_Leave(object sender, EventArgs e)
        {
            if (shoesize.Text == "")
            {
                shoesize.Text = "Введіть розмір взуття";
                shoesize.ForeColor = Color.Gray;
            }
        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            string heightValue = height.Text;

            if (string.IsNullOrWhiteSpace(heightValue) || heightValue == "Введіть зріст")
            {
                MessageBox.Show("Введіть коректний зріст.");
                height.Focus();
                return;
            }

            if (float.TryParse(heightValue, out float numericHeight))
            {
                if (numericHeight < 100 || numericHeight > 220)
                {
                    MessageBox.Show("Вибачте, але на даний момент є лижі лише для людей з ростом від 100 до 220 см.");
                    height.Focus();
                    return;
                }

                // Тепер перевіряємо розмір взуття
                string shoesizeValue = shoesize.Text;

                if (string.IsNullOrWhiteSpace(shoesizeValue) || shoesizeValue == "Введіть розмір взуття")
                {
                    MessageBox.Show("Введіть розмір взуття.");
                    shoesize.Focus();
                    return;
                }

                if (float.TryParse(shoesizeValue, out float numericShoeSize))
                {
                    if (numericShoeSize < 30 || numericShoeSize > 50)
                    {
                        MessageBox.Show("Вибачте, але на даний момент є лижі лише для людей з розміром взуття від 30 до 50.");
                        shoesize.Focus();
                        return;
                    }

                    // Тут ви можете вставити код для обробки розміру взуття, якщо необхідно

                    MessageBox.Show($"Ваш зріст: {numericHeight} см;\nВаш розмір взуття: {numericShoeSize};\nЯкщо всі дані коректні, натисніть кнопку Далі.");
                }
                else
                {
                    MessageBox.Show("Введіть коректне числове значення для розміру взуття.");
                    shoesize.Focus();
                }
            }
            else
            {
                MessageBox.Show("Введіть коректне числове значення для зросту.");
                height.Focus();
            }
        }

    }
}
