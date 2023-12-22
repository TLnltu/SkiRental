using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace it3
{
    public partial class Skiask : Form
    {
        public Skiask()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void weight_Enter(object sender, EventArgs e)
        {
            if (weight.Text == "Введіть вагу")
            {
                weight.Text = "";
                weight.ForeColor = Color.Black;
            }
        }
        private void weight_Leave(object sender, EventArgs e)
        {
            if (weight.Text == "")
            {
                weight.Text = "Введіть вагу";
                weight.ForeColor = Color.Gray;
            }
        }

        private void skillbox_Leave(object sender, EventArgs e)
        {
            if (skillbox.Text == "")
            {
                skillbox.Text = "Виберіть рівень професіоналізму";
                skillbox.ForeColor = Color.Gray;
            }
        }
        private void skillbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            skillbox.ForeColor = Color.Black;

        }
        private void skillbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) || (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            string weightValue = weight.Text;

            if (string.IsNullOrWhiteSpace(weightValue) || weightValue == "Введіть вагу")
            {
                MessageBox.Show("Введіть вагу.");
                weight.Focus();
                return;
            }

            if (float.TryParse(weightValue, out float numericWeight))
            {
                if (numericWeight < 30 || numericWeight > 160)
                {
                    MessageBox.Show("Вибачте, але на даний момент є лижі лише для людей з вагою від 30 до 170 см.");
                    weight.Focus();
                    return;
                }

                if (skillbox.SelectedIndex >= 0)
                {
                    // Виберіть відповідний розділ коду для ініціалізації та показу нової форми
                    equipmentask f = new equipmentask();
                    f.Show();

                    // Закрийте поточну форму тільки після відображення нової форми
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Виберіть рівень професіоналізму.");
                    skillbox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Введіть коректне числове значення для росту.");
                weight.Focus();
            }
        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            string weightValue = weight.Text;

            if (string.IsNullOrWhiteSpace(weightValue) || weightValue == "Введіть вагу")
            {
                MessageBox.Show("Введіть вагу.");
                weight.Focus();
                return;
            }

            if (float.TryParse(weightValue, out float numericWeight))
            {
                if (numericWeight < 30 || numericWeight > 160)
                {
                    MessageBox.Show("Вибачте, але на даний момент є лижі лише для людей з вагою від 30 до 170 кг.");
                    weight.Focus(); 
                    return;
                }

                if (skillbox.SelectedIndex >= 0)
                {
                    string selectedSkill = skillbox.SelectedItem.ToString();
                    MessageBox.Show("Ваш вага: " + numericWeight+"кг;" + "\nВаш рівень: " + selectedSkill+";" + "\nЯкщо всі дані коректні, натисніть кнопку Далі.");
                }
                else
                {
                    MessageBox.Show("Виберіть рівень професіоналізму.");
                    skillbox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Введіть коректне числове значення для росту.");
                weight.Focus();
                return;
            }
        }


    }
} 

    
